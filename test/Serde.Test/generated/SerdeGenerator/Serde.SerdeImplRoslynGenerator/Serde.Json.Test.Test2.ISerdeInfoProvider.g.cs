
#nullable enable

namespace Serde.Json.Test;

partial class Test2
{
    private static global::Serde.ISerdeInfo s_serdeInfo = Serde.SerdeInfo.MakeCustom(
        "Test2",
    typeof(Serde.Json.Test.Test2).GetCustomAttributesData(),
    new (string, global::Serde.ISerdeInfo, System.Reflection.MemberInfo?)[] {
        ("v2", global::Serde.SerdeInfoProvider.GetSerializeInfo<System.Numerics.Vector2, Serde.Json.Test.Vector2Proxy>(), typeof(Serde.Json.Test.Test2).GetField("v2")),
        ("vertices", global::Serde.SerdeInfoProvider.GetSerializeInfo<System.Numerics.Vector2[][], Serde.ArrayProxy.Ser<System.Numerics.Vector2[], Serde.ArrayProxy.Ser<System.Numerics.Vector2, Serde.Json.Test.Vector2Proxy>>>(), typeof(Serde.Json.Test.Test2).GetField("vertices")),
        ("weights", global::Serde.SerdeInfoProvider.GetSerializeInfo<System.Numerics.Vector2[][], Serde.ArrayProxy.Ser<System.Numerics.Vector2[], Serde.ArrayProxy.Ser<System.Numerics.Vector2, Serde.Json.Test.Vector2Proxy2>>>(), typeof(Serde.Json.Test.Test2).GetField("weights")),
        ("points", global::Serde.SerdeInfoProvider.GetSerializeInfo<System.Collections.Generic.Dictionary<System.Numerics.Vector3, System.Numerics.Vector2[][]>, Serde.DictProxy.Ser<System.Numerics.Vector3, System.Numerics.Vector2[][], Serde.Json.Test.Vector3Proxy, Serde.ArrayProxy.Ser<System.Numerics.Vector2[], Serde.ArrayProxy.Ser<System.Numerics.Vector2, Serde.Json.Test.Vector2Proxy>>>>(), typeof(Serde.Json.Test.Test2).GetField("points")),
        ("v4", global::Serde.SerdeInfoProvider.GetSerializeInfo<System.Numerics.Vector4, Serde.Json.Test.Vector4Proxy>(), typeof(Serde.Json.Test.Test2).GetField("v4"))
    }
    );
}
