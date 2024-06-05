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
    Type targetObjectClassType = targetObject.GetType();
    var field = targetObjectClassType.GetField(property.propertyPath);
    return targetObjectClassType.GetMethod(name,bindingAttr);
  }
}
