
#nullable enable

namespace Serde.Json.Test;

partial class Vector4Proxy
{
    private static global::Serde.ISerdeInfo s_serdeInfo = Serde.SerdeInfo.MakeCustom(
        "Vector4",
    typeof(System.Numerics.Vector4).GetCustomAttributesData(),
    new (string, global::Serde.ISerdeInfo, System.Reflection.MemberInfo?)[] {
        ("X", global::Serde.SerdeInfoProvider.GetSerializeInfo<float, global::Serde.F32Proxy>(), typeof(System.Numerics.Vector4).GetField("X")),
        ("Y", global::Serde.SerdeInfoProvider.GetSerializeInfo<float, global::Serde.F32Proxy>(), typeof(System.Numerics.Vector4).GetField("Y")),
        ("Z", global::Serde.SerdeInfoProvider.GetSerializeInfo<float, global::Serde.F32Proxy>(), typeof(System.Numerics.Vector4).GetField("Z")),
        ("W", global::Serde.SerdeInfoProvider.GetSerializeInfo<float, global::Serde.F32Proxy>(), typeof(System.Numerics.Vector4).GetField("W"))
    }
    );
}
