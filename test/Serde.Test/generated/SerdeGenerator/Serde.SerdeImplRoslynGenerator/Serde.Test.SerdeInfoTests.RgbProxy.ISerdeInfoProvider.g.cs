
#nullable enable

namespace Serde.Test;

partial class SerdeInfoTests
{
    partial record RgbProxy
    {
        private static global::Serde.ISerdeInfo s_serdeInfo = Serde.SerdeInfo.MakeCustom(
            "Rgb",
        typeof(Serde.Test.SerdeInfoTests.Rgb).GetCustomAttributesData(),
        new (string, global::Serde.ISerdeInfo, System.Reflection.MemberInfo?)[] {
            ("R", global::Serde.SerdeInfoProvider.GetDeserializeInfo<byte, global::Serde.U8Proxy>(), typeof(Serde.Test.SerdeInfoTests.Rgb).GetField("R")),
            ("G", global::Serde.SerdeInfoProvider.GetDeserializeInfo<byte, global::Serde.U8Proxy>(), typeof(Serde.Test.SerdeInfoTests.Rgb).GetField("G")),
            ("B", global::Serde.SerdeInfoProvider.GetDeserializeInfo<byte, global::Serde.U8Proxy>(), typeof(Serde.Test.SerdeInfoTests.Rgb).GetField("B"))
        }
        );
    }
}
