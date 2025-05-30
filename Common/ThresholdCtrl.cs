using HalconCalibration.Enums;
using HalconDotNet;

namespace HalconCalibration.Common;

public class ThresholdCtrl {
    private static readonly ThresholdCtrl _instance = new ThresholdCtrl();
    public static ThresholdCtrl Instance => _instance;

    private ThresholdCtrl() { }

    public double ThresholdMin{ get; set; } = 125.0;
    public double ThresholdMax{ get; set; } = 255.0;
    public double SelectShapeMin{ get; set; } = 150;
    public double SelectShapeMax{ get; set; } = 9999;

    public string Feature{ get; set; } = nameof(SelectShapeFeatures.area);
    public string Operator{ get; set; } = nameof(SelectShapeOperation.and);

    public HRegion? RegionValue{ get; set; }
    public HTuple? Row{ get; set; }
    public HTuple? Column{ get; set; }
    public HTuple? Area{ get; set; }
}