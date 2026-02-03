
#nullable enable

namespace Serde.Json.Test;

partial class Vector3Proxy
{
    private static global::Serde.ISerdeInfo s_serdeInfo = Serde.SerdeInfo.MakeCustom(
        "Vector3",
    typeof(System.Numerics.Vector3).GetCustomAttributesData(),
    new (string, global::Serde.ISerdeInfo, System.Reflection.MemberInfo?)[] {
        ("X", global::Serde.SerdeInfoProvider.GetSerializeInfo<float, global::Serde.F32Proxy>(), typeof(System.Numerics.Vector3).GetField("X")),
        ("Y", global::Serde.SerdeInfoProvider.GetSerializeInfo<float, global::Serde.F32Proxy>(), typeof(System.Numerics.Vector3).GetField("Y")),
        ("Z", global::Serde.SerdeInfoProvider.GetSerializeInfo<float, global::Serde.F32Proxy>(), typeof(System.Numerics.Vector3).GetField("Z"))
    }
    );
}
