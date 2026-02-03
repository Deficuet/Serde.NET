
#nullable enable

namespace Serde.Test;

partial class CustomImplTests
{
    partial record RgbWithFieldMap
    {
        private static global::Serde.ISerdeInfo s_serdeInfo = Serde.SerdeInfo.MakeCustom(
            "RgbWithFieldMap",
        typeof(Serde.Test.CustomImplTests.RgbWithFieldMap).GetCustomAttributesData(),
        new (string, global::Serde.ISerdeInfo, System.Reflection.MemberInfo?)[] {
            ("Red", global::Serde.SerdeInfoProvider.GetSerializeInfo<int, global::Serde.I32Proxy>(), typeof(Serde.Test.CustomImplTests.RgbWithFieldMap).GetField("Red")),
            ("Green", global::Serde.SerdeInfoProvider.GetSerializeInfo<int, global::Serde.I32Proxy>(), typeof(Serde.Test.CustomImplTests.RgbWithFieldMap).GetField("Green")),
            ("Blue", global::Serde.SerdeInfoProvider.GetSerializeInfo<int, global::Serde.I32Proxy>(), typeof(Serde.Test.CustomImplTests.RgbWithFieldMap).GetField("Blue"))
        }
        );
    }
}
