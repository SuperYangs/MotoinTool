using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MotoinTool
{
    public enum Io_Status
    {
        OFF,
        ON
    }

    //[ComVisible(true)]
    [Serializable]
    [Browsable(true),TypeConverter(typeof(IoInfoConverter))]
    public class IoInfo 
    {
        public int IoNum { get; set; }
        public string IoName { get; set; }
        //[JsonConverter(typeof(StringEnumConverter))]
        //[JsonIgnore]
        //[Browsable(false)]
        //public Io_Status IoStatus { get; set; }

    }

    public class IoInfoConverter : TypeConverter
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
                IoInfo ca = new IoInfo();
                ca.IoNum = Convert.ToInt32(sizeArr[0]);
                ca.IoName = Convert.ToString(sizeArr[1]);
               
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
                if (value is IoInfo)
                {
                    IoInfo ca = (IoInfo)value;
                    return ca.IoNum.ToString() + "," + ca.IoName;
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
            return TypeDescriptor.GetProperties(typeof(IoInfo), attributes);
        }
    }
}
