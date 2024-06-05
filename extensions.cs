using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Threading;

public static class SerializedPropertyExt{
  public static MethodInfo? GetMethod (this SerializedProperty propety,string name, BindingFlags bindingAttr)
  {
    var targetObject = property.serializedObject.targetObject;
    var targetObjectClassType = targetObject.GetType();
    var field = targetObjectClassType.GetField(property.propertyPath);
    var targetFieldType = field.FieldType;
    return targetFieldType.GetMethod(name,bindingAttr);
  }
  public static object? InvokeMethod (this SerializedProperty propety,string name, BindingFlags bindingAttr)
  {
    var targetObject = property.serializedObject.targetObject;
    var targetObjectClassType = targetObject.GetType();
    var field = targetObjectClassType.GetField(property.propertyPath);
    var targetFieldType = field.FieldType;
    object fieldObject = field.GetValue(targetObject);
    var methodInfo = targetFieldType.GetMethod(name,bindingAttr);
    if (methodInfo == null) return null;
    return methodInfo.Invoke(fieldObject,new object[]{});
  }
}
