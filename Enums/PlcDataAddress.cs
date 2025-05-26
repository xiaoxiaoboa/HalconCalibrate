using System.Reflection;

namespace HalconCalibration.Enums {
    public enum PlcDataAddress {
        [PlcAddress("DB50.DBD20")] X,

        [PlcAddress("DB50.DBD24")] Y,

        [PlcAddress("DB50.DBD28")] Z,

        [PlcAddress("DB50.DBD32")] R,
        [PlcAddress("DB50.DBD8")] NineCaliNum,
        [PlcAddress("DB51.DBD24")] NineCaliNumCheck,
        [PlcAddress("DB51.DBD16")] CenterCaliNumCheck,
        [PlcAddress("DB50.DBD12")] CenterCaliNum,
        [PlcAddress("DB51.DBD4")] OffsetX,
        [PlcAddress("DB51.DBD8")] OffsetY,
        [PlcAddress("DB51.DBD0")] OffsetR,
        [PlcAddress("DB51.DBD12")] MeasureNumCheck,
        [PlcAddress("DB50.DBD4")] MeasureNum,
    }

    [AttributeUsage(AttributeTargets.Field)]
    public class PlcAddressAttribute(string address) : Attribute
    {
        public string Address{ get; } = address;
    }

   public static class PlcTagExtensions {
    private const string AddressNotBoundMessage = "枚举 {0} 没有绑定地址";

    public static string GetAddress(this PlcDataAddress tag) {
        var memberInfo = GetMemberInfo(tag);
        var plcAddressAttribute = GetPlcAddressAttribute(memberInfo);

        return plcAddressAttribute?.Address 
            ?? throw new InvalidOperationException(string.Format(AddressNotBoundMessage, tag));
    }

    private static MemberInfo GetMemberInfo(PlcDataAddress tag) {
        return typeof(PlcDataAddress).GetMember(tag.ToString())[0];
    }

    private static PlcAddressAttribute GetPlcAddressAttribute(MemberInfo memberInfo) {
        return (PlcAddressAttribute)Attribute.GetCustomAttribute(
            memberInfo, typeof(PlcAddressAttribute))!;
    }
}
}