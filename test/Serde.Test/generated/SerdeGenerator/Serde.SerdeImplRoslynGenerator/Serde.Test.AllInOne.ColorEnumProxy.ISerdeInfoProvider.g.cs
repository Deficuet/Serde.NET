
#nullable enable

namespace Serde.Test;

partial record AllInOne
{
    partial class ColorEnumProxy : global::Serde.ISerdeInfoProvider
    {
        global::Serde.ISerdeInfo global::Serde.ISerdeInfoProvider.SerdeInfo { get; } = Serde.SerdeInfo.MakeEnum(
            "ColorEnum",
        typeof(Serde.Test.AllInOne.ColorEnum).GetCustomAttributesData(),
        global::Serde.SerdeInfoProvider.GetSerializeInfo<int, global::Serde.I32Proxy>(),
        new (string, System.Reflection.MemberInfo?)[] {
            ("Red", typeof(Serde.Test.AllInOne.ColorEnum).GetField("Red")),
            ("Blue", typeof(Serde.Test.AllInOne.ColorEnum).GetField("Blue")),
            ("Green", typeof(Serde.Test.AllInOne.ColorEnum).GetField("Green"))
        }
        );
    }
}
