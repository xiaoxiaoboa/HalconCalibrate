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

    // 阈值分割
    public bool HandleThreshold(HWindow? window, out string? errorMsg) {
        try {
            if (CameraCtrl.Instance.Image == null) throw new Exception("图像未加载");

            // 转灰度图
            HImage grayImage = CameraCtrl.Instance.Image.Rgb1ToGray();
            // 阈值分割
            HRegion thresholdRegion =
                grayImage.Threshold(ThresholdMin, ThresholdMax);
            // 连通
            HRegion connectionRegion = thresholdRegion.Connection();
            // 形状过滤
            HRegion selectRegion = connectionRegion.SelectShape(Feature,
                Operator, SelectShapeMin,
                Instance.SelectShapeMax);
            // 中心点和面积
            Area = selectRegion.AreaCenter(out HTuple row, out HTuple column);
            RegionValue = selectRegion;
            Row = row;
            Column = column;


            // 图像加载到控件
            window?.ClearWindow();
            grayImage.DispObj(window);
            selectRegion.DispObj(window);

            errorMsg = null;
            return true;
        }
        catch (Exception exception) {
            errorMsg = $"图像处理操作失败：{exception.Message}";
            return false;
        }
    }
}