
#nullable enable

namespace Serde.Test;

partial record AllInOne
{
    private static global::Serde.ISerdeInfo s_serdeInfo = Serde.SerdeInfo.MakeCustom(
        "AllInOne",
    typeof(Serde.Test.AllInOne).GetCustomAttributesData(),
    new (string, global::Serde.ISerdeInfo, System.Reflection.MemberInfo?)[] {
        ("BoolField", global::Serde.SerdeInfoProvider.GetSerializeInfo<bool, global::Serde.BoolProxy>(), typeof(Serde.Test.AllInOne).GetField("BoolField")),
        ("CharField", global::Serde.SerdeInfoProvider.GetSerializeInfo<char, global::Serde.CharProxy>(), typeof(Serde.Test.AllInOne).GetField("CharField")),
        ("ByteField", global::Serde.SerdeInfoProvider.GetSerializeInfo<byte, global::Serde.U8Proxy>(), typeof(Serde.Test.AllInOne).GetField("ByteField")),
        ("UShortField", global::Serde.SerdeInfoProvider.GetSerializeInfo<ushort, global::Serde.U16Proxy>(), typeof(Serde.Test.AllInOne).GetField("UShortField")),
        ("UIntField", global::Serde.SerdeInfoProvider.GetSerializeInfo<uint, global::Serde.U32Proxy>(), typeof(Serde.Test.AllInOne).GetField("UIntField")),
        ("ULongField", global::Serde.SerdeInfoProvider.GetSerializeInfo<ulong, global::Serde.U64Proxy>(), typeof(Serde.Test.AllInOne).GetField("ULongField")),
        ("UInt128Field", global::Serde.SerdeInfoProvider.GetSerializeInfo<System.UInt128, global::Serde.U128Proxy>(), typeof(Serde.Test.AllInOne).GetField("UInt128Field")),
        ("SByteField", global::Serde.SerdeInfoProvider.GetSerializeInfo<sbyte, global::Serde.I8Proxy>(), typeof(Serde.Test.AllInOne).GetField("SByteField")),
        ("ShortField", global::Serde.SerdeInfoProvider.GetSerializeInfo<short, global::Serde.I16Proxy>(), typeof(Serde.Test.AllInOne).GetField("ShortField")),
        ("IntField", global::Serde.SerdeInfoProvider.GetSerializeInfo<int, global::Serde.I32Proxy>(), typeof(Serde.Test.AllInOne).GetField("IntField")),
        ("LongField", global::Serde.SerdeInfoProvider.GetSerializeInfo<long, global::Serde.I64Proxy>(), typeof(Serde.Test.AllInOne).GetField("LongField")),
        ("Int128Field", global::Serde.SerdeInfoProvider.GetSerializeInfo<System.Int128, global::Serde.I128Proxy>(), typeof(Serde.Test.AllInOne).GetField("Int128Field")),
        ("StringField", global::Serde.SerdeInfoProvider.GetSerializeInfo<string, global::Serde.StringProxy>(), typeof(Serde.Test.AllInOne).GetField("StringField")),
        ("DateTimeOffsetField", global::Serde.SerdeInfoProvider.GetSerializeInfo<System.DateTimeOffset, global::Serde.DateTimeOffsetProxy>(), typeof(Serde.Test.AllInOne).GetField("DateTimeOffsetField")),
        ("DateTimeField", global::Serde.SerdeInfoProvider.GetSerializeInfo<System.DateTime, global::Serde.DateTimeProxy>(), typeof(Serde.Test.AllInOne).GetField("DateTimeField")),
        ("DateOnlyField", global::Serde.SerdeInfoProvider.GetSerializeInfo<System.DateOnly, global::Serde.DateOnlyProxy>(), typeof(Serde.Test.AllInOne).GetField("DateOnlyField")),
        ("TimeOnlyField", global::Serde.SerdeInfoProvider.GetSerializeInfo<System.TimeOnly, global::Serde.TimeOnlyProxy>(), typeof(Serde.Test.AllInOne).GetField("TimeOnlyField")),
        ("EscapedStringField", global::Serde.SerdeInfoProvider.GetSerializeInfo<string, global::Serde.StringProxy>(), typeof(Serde.Test.AllInOne).GetField("EscapedStringField")),
        ("NullStringField", global::Serde.SerdeInfoProvider.GetSerializeInfo<string?, Serde.NullableRefProxy.Ser<string, global::Serde.StringProxy>>(), typeof(Serde.Test.AllInOne).GetField("NullStringField")),
        ("UIntArr", global::Serde.SerdeInfoProvider.GetSerializeInfo<uint[], Serde.ArrayProxy.Ser<uint, global::Serde.U32Proxy>>(), typeof(Serde.Test.AllInOne).GetField("UIntArr")),
        ("NestedArr", global::Serde.SerdeInfoProvider.GetSerializeInfo<int[][], Serde.ArrayProxy.Ser<int[], Serde.ArrayProxy.Ser<int, global::Serde.I32Proxy>>>(), typeof(Serde.Test.AllInOne).GetField("NestedArr")),
        ("ByteArr", global::Serde.SerdeInfoProvider.GetSerializeInfo<byte[], global::Serde.ByteArrayProxy>(), typeof(Serde.Test.AllInOne).GetField("ByteArr")),
        ("IntImm", global::Serde.SerdeInfoProvider.GetSerializeInfo<System.Collections.Immutable.ImmutableArray<int>, Serde.ImmutableArrayProxy.Ser<int, global::Serde.I32Proxy>>(), typeof(Serde.Test.AllInOne).GetField("IntImm")),
        ("Color", global::Serde.SerdeInfoProvider.GetSerializeInfo<Serde.Test.AllInOne.ColorEnum, Serde.Test.AllInOne.ColorEnumProxy>(), typeof(Serde.Test.AllInOne).GetField("Color"))
    }
    );
}
