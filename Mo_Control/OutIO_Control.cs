using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotoinTool
{
    public partial class OutIO_Control : UserControl
    {
        public OutIO_Control()
        {
            InitializeComponent();
        }

        private string aName;
        private ActingInfo actingInfo = new ActingInfo()
        {
            ActingName = "动作名称",
            Acting_On = new IoInfo() { IoName = "开", IoNum = 0 },
            Acting_Off = new IoInfo() { IoName = "关", IoNum = 1 },
        };

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ActingInfo ActingInfo
        {
            get => actingInfo; 
            set => actingInfo = value;
        }

        public string Aname
        {
            get { return aName; }
            set
            {
                aName = value;
                actingInfo.ActingName = aName;
                btn_Open.Text = aName;
            }
        }


        public int Io_on
        {
            get => actingInfo.Acting_On.IoNum;
            set => actingInfo.Acting_On.IoNum = value;
        }
        public int Io_off
        {
            get => actingInfo.Acting_Off.IoNum;
            set => actingInfo.Acting_Off.IoNum = value;
        }
        public string _On
        {
            get => actingInfo.Acting_On.IoName;
            set => actingInfo.Acting_On.IoName = value;
        }
        public string _Off
        {
            get => actingInfo.Acting_Off.IoName;
            set
            {
                actingInfo.Acting_Off.IoName = value;
                lbl_Color.Text = _Off;
            }
        }


        private Io_Status status_On;
        private Io_Status status_Off;


        public override void Refresh()
        {
            //io_Status = MotionManage.moManage.motion.GetInIO(ioNum, out string error);
            //if (string.IsNullOrEmpty(error))
            //{
            //    switch (io_Status)
            //    {
            //        case Io_Status.OFF:
            //            lbl_Color.Text = Off;
            //            lbl_Color.BackColor = Color.Gray;
            //            break;
            //        case Io_Status.ON:
            //            lbl_Color.Text = On;
            //            lbl_Color.BackColor = Color.Green;
            //            break;
            //    }
            //}
            //else
            //{
            //    MessageBox.Show(error);
            //}
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            this.btn_Open.Enabled = false;
            if (GetStatus())
            {
                if (status_On == Io_Status.ON)
                {
                    Off();
                }
                else if (status_Off == Io_Status.ON || status_On == Io_Status.OFF)
                {
                    On();
                }
            }
            Thread.Sleep(300);
            this.btn_Open.Enabled = true;
        }

        private bool GetStatus()
        {
            var error1 = MotionManage.moManage.motion.GetOutIO(ActingInfo.Acting_On.IoNum,
                out status_On);
            if (!string.IsNullOrEmpty(error1))
            {
                MessageBox.Show(ActingInfo.Acting_On.IoName + error1);
                return false;
            }
            var error2 = MotionManage.moManage.motion.GetOutIO(ActingInfo.Acting_Off.IoNum,
                out status_Off);
            if (!string.IsNullOrEmpty(error2))
            {
                MessageBox.Show(ActingInfo.Acting_Off.IoName + error2);
                return false;
            }
            return true;

        }

        public void On()
        {
            if (ActingInfo.Acting_On.IoNum != ActingInfo.Acting_Off.IoNum)
                MotionManage.moManage.motion.SetOutIo(ActingInfo.Acting_Off.IoNum, Io_Status.OFF);
            MotionManage.moManage.motion.SetOutIo(ActingInfo.Acting_On.IoNum, Io_Status.ON);
            lbl_Color.Text = _On;
            lbl_Color.BackColor = Color.Green;
        }
        public void Off()
        {
            MotionManage.moManage.motion.SetOutIo(ActingInfo.Acting_On.IoNum, Io_Status.OFF);
            if (ActingInfo.Acting_On.IoNum != ActingInfo.Acting_Off.IoNum)
                MotionManage.moManage.motion.SetOutIo(ActingInfo.Acting_Off.IoNum, Io_Status.ON);
            lbl_Color.Text = _Off;
            lbl_Color.BackColor = Color.Gray;
        }
        private void OutIO_Control_Load(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    Thread.Sleep(10);
                    Refresh();
                }
            });
        }
    }
    [Browsable(true),TypeConverter(typeof(CustomAttriConverter))]
    public class ActingInfo
    {
        public string ActingName { get; set; }

        public IoInfo Acting_On { get; set; }

        public IoInfo Acting_Off { get; set; }

        public ActingInfo()
        {

        }
    }

    /// <summary>
    /// 自定义类型转换器
    /// </summary>
    public class CustomAttriConverter : TypeConverter
    {
        /// <summary>
        /// 表示是否允许将给定类型的对象转换为自定义类型
        /// </summary>
        /// <param name="context">当前上下文对象</param>
        /// <param name="sourceType">给定的类型</param>
        /// <returns></returns>
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            //如果给定的类型为字符串，可以转换为自定义类型
            if (sourceType == typeof(string))
            {
                return true;
            }
            return base.CanConvertFrom(context, sourceType);
        }

        /// <summary>
        /// 表示是否允许将自定义类型转换为指定的类型
        /// </summary>
        /// <param name="context">当前上下文</param>
        /// <param name="destinationType">指定的类型</param>
        /// <returns></returns>
        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            //如果目标类型是字符串，允许将自定义类型转换为字符串
            if (destinationType == typeof(string))
            {
                return true;
            }
            return base.CanConvertTo(context, destinationType);
        }

        /// <summary>
        /// 将指定类型转换为自定义类型
        /// </summary>
        /// <param name="context">当前上下文信息</param>
        /// <param name="culture">区域信息</param>
        /// <param name="value">指定类型</param>
        /// <returns></returns>
        public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
        {
            if (value is string)
            {
                string[] sizeArr = ((string)value).Split(',');//将输入的字符串以逗号进行分割
                ActingInfo ca = new ActingInfo();
                ca.ActingName = Convert.ToString(sizeArr[0]);
                //ca.Height = Convert.ToInt16(sizeArr[1]);
                return ca;
            }
            return base.ConvertFrom(context, culture, value);
        }

        /// <summary>
        /// 将自定义类型转换为指定类型
        /// </summary>
        /// <param name="context">当前上下文</param>
        /// <param name="culture">区域</param>
        /// <param name="value"></param>
        /// <param name="destinationType">指定类型</param>
        /// <returns></returns>
        public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType)
        {
            //如果要转换为自定义类型
            if (destinationType == typeof(string))
            {
                if (value is ActingInfo)
                {
                    ActingInfo ca = (ActingInfo)value;
                    return ca.ActingName.ToString();
                }
            }
            return base.ConvertTo(context, culture, value, destinationType);
        }

        /// <summary>
        /// 返回此对象是否支持属性。
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override bool GetPropertiesSupported(ITypeDescriptorContext context)
        {
            return true;
        }

        public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
        {
            //return base.GetProperties(context, value, attributes);
            return TypeDescriptor.GetProperties(typeof(ActingInfo), attributes);
        }
    }

    /// <summary>     
    /// 实现类型属性分别编辑的通用类型转换器
    /// </summary>     
    /// <typeparam name="T">泛型</typeparam>  
    public class GeneralTypeConverter<T> : TypeConverter where T : new()
    {
        /// <summary>
        /// 返回此转换器是否可以将一种类型的对象转换为此转换器的类型。
        /// </summary>
        /// <param name="context">提供格式上下文的ITypeDescriptorContext。</param>
        /// <param name="sourceType">表示你想从转换的类型</param>
        /// <returns>返回为True则可以转换，为false则不能转换</returns>
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            if (sourceType == typeof(string))
            {
                return true;
            }
            return base.CanConvertFrom(context, sourceType);
        }

        /// <summary>
        /// 使用指定的上下文和区域性信息将给定对象转换为此转换器的类型
        /// </summary>
        /// <param name="context">一个 ITypeDescriptorContext，用于提供格式上下文</param>
        /// <param name="culture">CultureInfo 要用作当前区域性</param>
        /// <param name="value">要转换的 Object</param>
        /// <returns>转换后的值</returns>
        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            string strValue = (value as string).Trim();
            if (strValue == null)
            {
                return base.ConvertFrom(context, culture, value);
            }
            strValue = strValue.Trim();
            if (strValue.Length == 0)
            {
                return null;
            }
            if (culture == null)
            {
                culture = CultureInfo.CurrentCulture;
            }
            char separator = ';';//采用英文分号隔开，与下面的ConvertTo对应
            Type type = typeof(T);
            //1、去掉“ClassName { ”和“ }”两部分   ，与下面的ConvertTo对应
            string withStart = "{ ";
            string withEnd = " }";
            if (strValue.StartsWith(withStart) && strValue.EndsWith(withEnd))
            {
                strValue = strValue.Substring(withStart.Length, strValue.Length - withStart.Length - withEnd.Length);
            }
            //2、分割属性值     
            string[] strArray = strValue.Split(new char[] { separator });
            //3、做成属性集合表     
            Hashtable properties = new Hashtable();
            for (int i = 0; i < strArray.Length; i++)
            {
                if (strArray[i].Trim().IndexOf('=') != -1)
                {
                    string[] str = strArray[i].Trim().Split(new char[] { '=' });
                    string propName = str[0];
                    PropertyInfo pi = type.GetProperty(str[0]);
                    if (pi != null)
                    {
                        //该属性对应类型的类型转换器     
                        TypeConverter converter = TypeDescriptor.GetConverter(pi.PropertyType);
                        properties.Add(propName, converter.ConvertFromString(str[1]));
                    }
                }
            }
            return this.CreateInstance(context, properties);
        }

        /// <summary>
        /// 返回此转换器是否可将该对象转换为指定的类型。
        /// </summary>
        /// <param name="context">提供格式上下文的ITypeDescriptorContext。</param>
        /// <param name="sourceType">表示你想从转换的类型</param>
        /// <returns>返回为True则可以转换，为false则不能转换</returns>
        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            if (destinationType == typeof(InstanceDescriptor))
            {
                return true;
            }
            return base.CanConvertTo(context, destinationType);
        }
        /// <summary>
        /// 使用指定的上下文和区域性信息将给定的值对象转换为指定的类型
        /// </summary>
        /// <param name="context">一个提供格式上下文的 System.ComponentModel.ITypeDescriptorContext。</param>
        /// <param name="culture">System.Globalization.CultureInfo。如果传递 null，则采用当前区域性</param>
        /// <param name="value"> 要转换的 System.Object。</param>
        /// <param name="destinationType">value 参数要转换到的 System.Type。</param>
        /// <returns>表示转换的 value 的 System.Object。</returns>
        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType == null)
            {
                throw new ArgumentNullException("DestinationType");
            }
            //如果需要返回详细信息则
            if (value is T)
            {
                if (destinationType == typeof(string))
                {
                    if (culture == null)
                    {
                        culture = CultureInfo.CurrentCulture;
                    }
                    string separator = "; ";//采用英文分号隔开，与ConvertFrom对应
                    StringBuilder sb = new StringBuilder();
                    Type type = value.GetType();
                    //组合为属性窗口显示的值
                    sb.Append("{ ");
                    PropertyInfo[] proInfo = type.GetProperties(BindingFlags.Instance | BindingFlags.Public);
                    for (int i = 0; i < proInfo.Length; i++)
                    {
                        if (!proInfo[i].CanRead) continue;
                        //只显示可见的
                        object[] attributes = proInfo[i].GetCustomAttributes(typeof(BrowsableAttribute), false);
                        bool isBrowsable = true;
                        foreach (object obj in attributes)
                        {
                            isBrowsable = (obj as BrowsableAttribute).Browsable;
                        }
                        if (isBrowsable == false)
                        {
                            continue;
                        }
                        Type typeProp = proInfo[i].PropertyType;
                        string nameProp = proInfo[i].Name;
                        object valueProp = proInfo[i].GetValue(value, null);
                        TypeConverter converter = TypeDescriptor.GetConverter(typeProp);
                        sb.AppendFormat("{0}={1}" + separator, nameProp, converter.ConvertToString(context, valueProp));
                    }
                    string strContent = sb.ToString();
                    if (strContent.EndsWith(separator))
                    {
                        strContent = strContent.Substring(0, strContent.Length - separator.Length);
                    }
                    strContent += " }";
                    return strContent.Trim();
                }
                if (destinationType == typeof(InstanceDescriptor))
                {
                    ConstructorInfo constructor = typeof(T).GetConstructor(new Type[0]);
                    if (constructor != null)
                    {
                        return new InstanceDescriptor(constructor, new object[0], false);
                    }
                }
            }
            return base.ConvertTo(context, culture, value, destinationType);
        }

        /// <summary>
        /// 在已知对象的属性值集的情况下，使用指定的上下文创建与此关联的类型的实例。
        /// </summary>
        /// <param name="context">一个提供格式上下文的ITypeDescriptorContext</param>
        /// <param name="propertyValues">新属性值的IDictionary。</param>
        /// <returns>一个 System.Object，表示给定的IDictionary，或者，如果无法创建该对象，则为 null。此方法始终返回</returns>
        public override object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues)
        {
            if (propertyValues == null)
            {
                throw new ArgumentNullException("propertyValues");
            }
            Type type = typeof(T);
            ConstructorInfo ctrInfo = type.GetConstructor(new Type[0]);
            if (ctrInfo == null)
            {
                return null;
            }
            //调用默认的构造函数构造实例     
            object obj = ctrInfo.Invoke(new object[0]);
            //设置属性值   
            PropertyInfo[] proInfo = type.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            object propValue = null;
            for (int i = 0; i < proInfo.Length; i++)
            {
                //判断是否具有Set方法
                if (!proInfo[i].CanWrite)
                {
                    continue;
                }
                propValue = propertyValues[proInfo[i].Name];
                if (propValue != null)
                {
                    proInfo[i].SetValue(obj, propValue, null);
                }
            }
            return obj;
        }

        /// <summary>
        /// 返回更改此对象的值是否要求调用CreateInstance(System.Collections.IDictionary)方法来创建新值。
        /// </summary>
        /// <param name="context">一个提供格式上下文的 System.ComponentModel.ITypeDescriptorContext</param>
        /// <returns>如果更改此对象的属性需要调用CreateInstance(System.Collections.IDictionary)来创建新值，则为 true；否则为 false。</returns>
        public override bool GetCreateInstanceSupported(ITypeDescriptorContext context)
        {
            return true;
        }

        /// <summary>
        /// 使用指定的上下文和特性返回由 value 参数指定的数组类型的属性的集合
        /// </summary>
        /// <param name="context">一个提供格式上下文的ITypeDescriptorContext</param>
        /// <param name="value">一个 System.Object，指定要为其获取属性的数组类型</param>
        /// <param name="attributes">用作筛选器的 System.Attribute 类型数组。</param>
        /// <returns>具有为此数据类型公开的属性的 PropertyDescriptorCollection；或者，如果没有属性，则为null。</returns>
        public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
        {
            Type type = value.GetType();
            PropertyInfo[] proInfo = type.GetProperties(BindingFlags.Instance | BindingFlags.Public);
            string[] names = new string[proInfo.Length];
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = proInfo[i].Name;
            }
            Array.Sort<string>(names);
            return TypeDescriptor.GetProperties(typeof(T), attributes).Sort(names);
        }
        /// <summary>
        /// 使用指定的上下文返回该对象是否支持属性。
        /// </summary>
        /// <param name="context">一个提供格式上下文的 System.ComponentModel.ITypeDescriptorContext</param>
        /// <returns>如果应调用 System.ComponentModel.TypeConverter.GetProperties(System.Object) 来查找此对象的属性，则为true；否则为 false。</returns>
        public override bool GetPropertiesSupported(ITypeDescriptorContext context)
        {
            return true;
        }
    }

}
