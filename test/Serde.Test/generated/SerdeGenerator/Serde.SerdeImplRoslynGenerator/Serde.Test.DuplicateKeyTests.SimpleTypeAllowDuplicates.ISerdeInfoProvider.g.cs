
#nullable enable

namespace Serde.Test;

partial class DuplicateKeyTests
{
    partial struct SimpleTypeAllowDuplicates
    {
        private static global::Serde.ISerdeInfo s_serdeInfo = Serde.SerdeInfo.MakeCustom(
            "SimpleTypeAllowDuplicates",
        typeof(Serde.Test.DuplicateKeyTests.SimpleTypeAllowDuplicates).GetCustomAttributesData(),
        new (string, global::Serde.ISerdeInfo, System.Reflection.MemberInfo?)[] {
            ("Name", global::Serde.SerdeInfoProvider.GetDeserializeInfo<string, global::Serde.StringProxy>(), typeof(Serde.Test.DuplicateKeyTests.SimpleTypeAllowDuplicates).GetProperty("Name")),
            ("Value", global::Serde.SerdeInfoProvider.GetDeserializeInfo<int, global::Serde.I32Proxy>(), typeof(Serde.Test.DuplicateKeyTests.SimpleTypeAllowDuplicates).GetProperty("Value"))
        }
        );
    }
}
