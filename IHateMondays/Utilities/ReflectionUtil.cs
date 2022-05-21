using System;
using System.Reflection;

namespace IHateMondays.Utilities
{
    public static class ReflectionUtil
    {
        private const BindingFlags _allBindingFlags = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;

        public static object GetProperty(this object obj, string propertyName)
        {
            return (obj is Type ? (Type)obj : obj.GetType())
                .GetProperty(propertyName, _allBindingFlags)
                .GetValue(obj);
        }

        public static T GetProperty<T>(this object obj, string propertyName) => (T)GetProperty(obj, propertyName);
    }
}
