using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Threading;

public static class SerializedObjectExt{
  public static T GetMethod(this SerializedObject sobj,string methodName){
    var targetObject = property.serializedObject.targetObject;
    var targetObjectClassType = targetObject.GetType();
    var field = targetObjectClassType.GetField(property.propertyPath);
    if (field != null)
    {
      var value = field.GetValue(targetObject);
      Debug.Log(value.s);
    }
  }
}
