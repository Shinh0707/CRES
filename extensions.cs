using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Threading;

public static class SerializedObjectExt{
  public static MethodInfo? GetMethod (this SerializedObject sobj,string name, BindingFlags bindingAttr)
  {
    var targetObject = property.serializedObject.targetObject;
    var targetObjectClassType = targetObject.GetType();
    var field = targetObjectClassType.GetField(property.propertyPath);
    var targetFieldType = field.FieldType;
    return targetFieldType.GetMethod(name,bindingAttr);
  }
}

public static class MethodInfoExt{
  public static T Invoke<T>(this MethodInfo methodInfo,object classObject)
  {
    if (methodInfo.)
    return methodInfo.Invoke(classObject,new object[]{}) as T;
  }
}

