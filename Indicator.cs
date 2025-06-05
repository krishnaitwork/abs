#region Assembly TradingPlatform.BusinessLayer, Version=1.0.96.0, Culture=neutral, PublicKeyToken=null
// C:\Application Files\Quantower\Quantower.in\TradingPlatform\v1.0.96\bin\TradingPlatform.BusinessLayer.dll
// Decompiled with ICSharpCode.Decompiler 8.2.0.7535
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using _003CPrivateImplementationDetails_003E_007B97AB1A55_002DA700_002D43FC_002D9501_002D183BC14A3746_007D;
using TradingPlatform.BusinessLayer.Chart;
using TradingPlatform.BusinessLayer.Utils;
using 봜;

namespace TradingPlatform.BusinessLayer;

//
// Summary:
//     Base class for all indicators.
[Published]
public abstract class Indicator : ExecutionEntity, IIndicatorsCollection
{
    private class 봜
    {
        [CompilerGenerated]
        private Color? 볖봙;

        [CompilerGenerated]
        private Color? 볖봐;

        public Color? BeginColor
        {
            [CompilerGenerated]
            get
            {
                return 볖봙;
            }
            [CompilerGenerated]
            set
            {
                볖봙 = value;
            }
        }

        public Color? EndColor
        {
            [CompilerGenerated]
            get
            {
                return 볖봐;
            }
            [CompilerGenerated]
            set
            {
                볖봐 = value;
            }
        }

        public override string ToString()
        {
            DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 2);
            defaultInterpolatedStringHandler.AppendLiteral(C1A5560D_002D169D_002D4815_002DBB20_002D0CA0DFEA0746.볌봳());
            defaultInterpolatedStringHandler.AppendFormatted(BeginColor);
            defaultInterpolatedStringHandler.AppendLiteral(C1A5560D_002D169D_002D4815_002DBB20_002D0CA0DFEA0746.볌볻());
            defaultInterpolatedStringHandler.AppendFormatted(EndColor);
            return defaultInterpolatedStringHandler.ToStringAndClear();
        }
    }

    [NotPublished]
    public const string EMA = "Exponential Moving Average";

    [NotPublished]
    public const string LWMA = "Linearly Weighted Moving Average";

    [NotPublished]
    public const string SMA = "Simple Moving Average";

    [NotPublished]
    public const string SMMA = "Smoothed Moving Average";

    [NotPublished]
    public const string PPMA = "Pivot Point Moving Average";

    [NotPublished]
    public const string CCI = "Commodity Channel Index";

    [NotPublished]
    public const string MAS3 = "3MASignal";

    [NotPublished]
    public const string MMA = "Modified Moving Average";

    [NotPublished]
    public const string Regression = "Regression Line";

    [NotPublished]
    public const string BB = "Bollinger Bands";

    [NotPublished]
    public const string Channel = "Price Channel";

    [NotPublished]
    public const string AFIRMA = "Autoregressive Finite Impulse Response Moving Average";

    [NotPublished]
    public const string RSI = "Relative Strength Index";

    [NotPublished]
    public const string MD = "McGinley Dynamic";

    [NotPublished]
    public const string MAE = "Moving Average Envelope";

    [NotPublished]
    public const string SAR = "Parabolic SAR";

    [NotPublished]
    public const string AO = "Awesome Oscillator";

    [NotPublished]
    public const string CMO = "Chande Momentum Oscillator";

    [NotPublished]
    public const string ZZ = "ZigZag";

    [NotPublished]
    public const string AROON = "Aroon";

    [NotPublished]
    public const string MACD = "Moving Average Convergence/Divergence";

    [NotPublished]
    public const string SD = "Standard Deviation";

    [NotPublished]
    public const string KRI = "Kairi Relative Index";

    [NotPublished]
    public const string BBF = "Bollinger Bands Flat";

    [NotPublished]
    public const string ROC = "Rate of Change";

    [NotPublished]
    public const string Momentum = "Momentum";

    [NotPublished]
    public const string RLW = "%R Larry Williams";

    [NotPublished]
    public const string PO = "Price Oscillator";

    [NotPublished]
    public const string OBV = "On Balance Volume";

    [NotPublished]
    public const string OsMA = "Moving Average of Oscillator";

    [NotPublished]
    public const string PVI = "Positive Volume Index";

    [NotPublished]
    public const string VOLUME = "Volume";

    [NotPublished]
    public const string MFI = "Money Flow Index";

    [NotPublished]
    public const string AC = "Acceleration Oscillator";

    [NotPublished]
    public const string ATR = "Average True Range";

    [NotPublished]
    public const string KAMA = "Kaufman Adaptive Moving Average";

    [NotPublished]
    public const string Stochastic = "Stochastic Slow";

    [NotPublished]
    public const string StochasticxRSI = "Stochastic x Relative Strength Index";

    [NotPublished]
    public const string Qstick = "Qstick";

    [NotPublished]
    public const string SI = "Swing Index";

    [NotPublished]
    public const string ADX = "Average Directional Index";

    [NotPublished]
    public const string Keltner = "Keltner Channel";

    [NotPublished]
    public const string PPO = "Percentage Price Oscillator";

    [NotPublished]
    public const string TSI = "True Strength Index";

    [NotPublished]
    public const string DMI = "Directional Movement Index";

    [NotPublished]
    public const string ICH = "Ichimoku";

    [NotPublished]
    public const string Alligator = "Alligator";

    [NotPublished]
    public const string HV = "Historical Volatility";

    [NotPublished]
    public const string PAZ = "Price Action Zones";

    [NotPublished]
    public const string OSCILLATOR_GROUP = "Oscillators";

    [NotPublished]
    public const string MOVING_AVERAGE_GROUP = "Moving averages";

    [NotPublished]
    public const string TREND_GROUP = "Trend";

    [NotPublished]
    public const string VOLATILITY_GROUP = "Volatility";

    [NotPublished]
    public const string CHANNEL_GROUP = "Channels";

    [NotPublished]
    public const string VOLUME_GROUP = "Volume";

    [NotPublished]
    public const string HIDDEN_GROUP = "Hidden";

    [NotPublished]
    protected internal const IndicatorCalculationType DEFAULT_CALCULATION_TYPE = IndicatorCalculationType.ByPeriod;

    private string 볩볊;

    [CompilerGenerated]
    private int 볩봨;

    [CompilerGenerated]
    private HistoricalData 볩봊;

    [CompilerGenerated]
    private bool 볩봰;

    [CompilerGenerated]
    private bool 볩뵈;

    [CompilerGenerated]
    private bool 볩뵁 = true;

    [CompilerGenerated]
    private int 볩봿 = -1;

    [CompilerGenerated]
    private TimeFrameConfig 볩봲 = new TimeFrameConfig();

    [CompilerGenerated]
    private IndicatorUpdateType 볩볫;

    [CompilerGenerated]
    private bool 볩봥 = true;

    private const string 볩봡 = "Line_";

    private const string 볩볜 = "Level_";

    [CompilerGenerated]
    private IChart 볩봃;

    private readonly List<LineSeries> 볩볦;

    private readonly List<LineLevel> 볩봞;

    private readonly object 볩볽;

    private readonly List<Indicator> 볩볝;

    private readonly object 볩봄;

    private readonly List<HistoricalDataCustom> 볩볷;

    private readonly object 볩봟;

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obfuscation(Exclude = true)]
    private bool debugMode;

    private bool 볩볼;

    private readonly IDictionary<IndicatorCloudKey, List<봜>> 볩볞;

    private readonly object 볩봻;

    private readonly List<IndicatorBarAppearance> 볩볱;

    //
    // Summary:
    //     Short name of indicator
    public virtual string ShortName
    {
        get
        {
            if (string.IsNullOrEmpty(볩볊))
            {
                return base.Name;
            }

            return 볩볊;
        }
        [Obsolete("Override getter")]
        protected set
        {
            볩볊 = value;
        }
    }

    //
    // Summary:
    //     Access to current Symbol of indicator
    public Symbol Symbol => HistoricalData?.Symbol;

    //
    // Summary:
    //     Amount of items in internal buffers
    public int Count
    {
        [CompilerGenerated]
        get
        {
            return 볩봨;
        }
        [CompilerGenerated]
        private set
        {
            볩봨 = value;
        }
    }

    //
    // Summary:
    //     Represent access to current used historical data.
    public HistoricalData HistoricalData
    {
        [CompilerGenerated]
        get
        {
            return 볩봊;
        }
        [CompilerGenerated]
        internal set
        {
            볩봊 = value;
        }
    }

    //
    // Summary:
    //     Represent access indicator series
    public LineSeries[] LinesSeries => 볩볦.ToArray();

    public LineLevel[] LinesLevels => 볩봞.ToArray();

    //
    // Summary:
    //     Specified, whether indicator should use main or additional window on the chart
    public bool SeparateWindow
    {
        [CompilerGenerated]
        get
        {
            return 볩봰;
        }
        [CompilerGenerated]
        set
        {
            볩봰 = value;
        }
    }

    //
    // Summary:
    //     Specified, whether indicator should draw on chart background by default.
    public bool OnBackGround
    {
        [CompilerGenerated]
        get
        {
            return 볩뵈;
        }
        [CompilerGenerated]
        set
        {
            볩뵈 = value;
        }
    }

    //
    // Summary:
    //     Specified, whether indicator should participate into price auto scale system.
    public bool AllowFitAuto
    {
        [CompilerGenerated]
        get
        {
            return 볩뵁;
        }
        [CompilerGenerated]
        set
        {
            볩뵁 = value;
        }
    }

    //
    // Summary:
    //     Precision amount for formatting price (the count of digits after decimal point);
    //     By default = -1, which means to use precision from indicator's symbol
    public int Digits
    {
        [CompilerGenerated]
        get
        {
            return 볩봿;
        }
        [CompilerGenerated]
        set
        {
            볩봿 = value;
        }
    }

    public TimeFrameConfig TFConfig
    {
        [CompilerGenerated]
        get
        {
            return 볩봲;
        }
        [CompilerGenerated]
        private set
        {
            볩봲 = value;
        }
    }

    public IndicatorUpdateType UpdateType
    {
        [CompilerGenerated]
        get
        {
            return 볩볫;
        }
        [CompilerGenerated]
        set
        {
            볩볫 = value;
        }
    }

    protected bool IsUpdateTypesSupported
    {
        [CompilerGenerated]
        get
        {
            return 볩봥;
        }
        [CompilerGenerated]
        set
        {
            볩봥 = value;
        }
    }

    //
    // Summary:
    //     Indicator's settings
    public override IList<SettingItem> Settings
    {
        get
        {
            IList<SettingItem> settings = base.Settings;
            if (볩볦 != null)
            {
                for (int i = 0; i < 볩볦.Count; i++)
                {
                    int num = i + 1;
                    LineSeries lineSeries = 볩볦[i];
                    string text = string.Format(loc._(C1A5560D_002D169D_002D4815_002DBB20_002D0CA0DFEA0746.봩볔(), null, C1A5560D_002D169D_002D4815_002DBB20_002D0CA0DFEA0746.봩볡()), num);
                    SettingItemSeparatorGroup separatorGroup = new SettingItemSeparatorGroup((string.IsNullOrEmpty(lineSeries.Name) || lineSeries.Name.Contains(C1A5560D_002D169D_002D4815_002DBB20_002D0CA0DFEA0746.봩볏())) ? text : string.Format(loc._(C1A5560D_002D169D_002D4815_002DBB20_002D0CA0DFEA0746.봩볒(), null, C1A5560D_002D169D_002D4815_002DBB20_002D0CA0DFEA0746.봩볡()), lineSeries.Name), num);
                    IList<SettingItem> settings2 = lineSeries.Settings;
                    foreach (SettingItem item in settings2)
                    {
                        item.SeparatorGroup = separatorGroup;
                    }

                    settings.Add(new SettingItemGroup($"{C1A5560D_002D169D_002D4815_002DBB20_002D0CA0DFEA0746.봩볏()}{i}", settings2)
                    {
                        Text = text + C1A5560D_002D169D_002D4815_002DBB20_002D0CA0DFEA0746.봩보()
                    });
                }

                if (볩봞 != null)
                {
                    for (int j = 0; j < 볩봞.Count; j++)
                    {
                        int num2 = 볩볦.Count + j;
                        LineLevel lineLevel = 볩봞[j];
                        string text2 = string.Format(loc._(C1A5560D_002D169D_002D4815_002DBB20_002D0CA0DFEA0746.봩볗(), null, C1A5560D_002D169D_002D4815_002DBB20_002D0CA0DFEA0746.봩볡()), j + 1);
                        SettingItemSeparatorGroup separatorGroup2 = new SettingItemSeparatorGroup((string.IsNullOrEmpty(lineLevel.Name) || lineLevel.Name.Contains(C1A5560D_002D169D_002D4815_002DBB20_002D0CA0DFEA0746.봩봍())) ? text2 : string.Format(loc._(C1A5560D_002D169D_002D4815_002DBB20_002D0CA0DFEA0746.봩볒(), null, C1A5560D_002D169D_002D4815_002DBB20_002D0CA0DFEA0746.봩볡()), lineLevel.Name), num2 + 1);
                        IList<SettingItem> settings3 = lineLevel.Settings;
                        foreach (SettingItem item2 in settings3)
                        {
                            item2.SeparatorGroup = separatorGroup2;
                        }

                        settings.Add(new SettingItemGroup($"{C1A5560D_002D169D_002D4815_002DBB20_002D0CA0DFEA0746.봩볏()}{num2}", settings3)
                        {
                            Text = text2 + C1A5560D_002D169D_002D4815_002DBB20_002D0CA0DFEA0746.봩보()
                        });
                    }
                }
            }

            if (HistoricalData != null && (TFConfig.DefaultAggregation == null || (HistoricalData.Aggregation != null && !HistoricalData.Aggregation.Equals(TFConfig.DefaultAggregation))))
            {
                TFConfig.DefaultAggregation = HistoricalData.Aggregation;
            }

            settings.Add(new SettingItemTimeFrameConfig(C1A5560D_002D169D_002D4815_002DBB20_002D0CA0DFEA0746.볶볻(), TFConfig)
            {
                SeparatorGroup = new SettingItemSeparatorGroup(string.Empty, 1000)
            });
            List<SelectItem> list = new List<SelectItem>
            {
                new SelectItem(C1A5560D_002D169D_002D4815_002DBB20_002D0CA0DFEA0746.봩봧(), 0),
                new SelectItem(C1A5560D_002D169D_002D4815_002DBB20_002D0CA0DFEA0746.봩봸(), 1)
            };
            if (IsUpdateTypesSupported)
            {
                settings.Add(new SettingItemSelectorLocalized(C1A5560D_002D169D_002D4815_002DBB20_002D0CA0DFEA0746.봩봅(), list.GetItemByValue((int)UpdateType), list)
                {
                    SeparatorGroup = new SettingItemSeparatorGroup(string.Empty, 1100)
                });
            }

            return settings;
        }
        set
        {
            base.Settings = value;
            foreach (SettingItem item in value)
            {
                if (!(item is SettingItemGroup { Value: IList<SettingItem> value2 }) || !value2.Any() || value2[0].Group == null || !int.TryParse(value2[0].Group.Name.Replace(C1A5560D_002D169D_002D4815_002DBB20_002D0CA0DFEA0746.봩볏(), C1A5560D_002D169D_002D4815_002DBB20_002D0CA0DFEA0746.볹()), out var result))
                {
                    continue;
                }

                if (result < 볩볦.Count)
                {
                    볩볦[result].Settings = value2;
                    continue;
                }

                int num = result - 볩볦.Count;
                if (num < 볩봞.Count)
                {
                    볩봞[num].Settings = value2;
                }
            }

            bool flag = false;
            if (value.GetItemByName(C1A5560D_002D169D_002D4815_002DBB20_002D0CA0DFEA0746.볶볻()) is SettingItemTimeFrameConfig settingItemTimeFrameConfig)
            {
                TFConfig = (TimeFrameConfig)settingItemTimeFrameConfig.Value;
            }

            if (IsUpdateTypesSupported && value.GetItemByName(C1A5560D_002D169D_002D4815_002DBB20_002D0CA0DFEA0746.봩봅()) is SettingItemSelectorLocalized settingItemSelectorLocalized)
            {
                UpdateType = (IndicatorUpdateType)(int)(object)((SelectItem)settingItemSelectorLocalized.Value).Value;
                flag = settingItemSelectorLocalized.ValueChangingReason == SettingItemValueChangingReason.Manually;
            }

            if (flag)
            {
                OnSettingsUpdated();
            }
        }
    }

    //
    // Summary:
    //     Represent access to the chart, that created indicator
    public IChart CurrentChart
    {
        [CompilerGenerated]
        get
        {
            return 볩봃;
        }
        [CompilerGenerated]
        set
        {
            볩봃 = value;
        }
    }

    public virtual string HelpLink => string.Empty;

    public virtual string SourceCodeLink => string.Empty;

    internal int ChildIndicatorsCount
    {
        get
        {
            lock (볩봄)
            {
                return 볩볝.Count;
            }
        }
    }

    protected virtual void OnInit()
    {
    }

    protected virtual void OnUpdate(UpdateArgs args)
    {
    }

    protected virtual void OnClear()
    {
    }

    public LineSeries AddLineSeries(string lineName = "", Color lineColor = default(Color), int lineWidth = 1, LineStyle lineStyle = LineStyle.Solid)
    {
        if (string.IsNullOrEmpty(lineName))
        {
            lineName = $"{C1A5560D_002D169D_002D4815_002DBB20_002D0CA0DFEA0746.봩볏()}{볩볦.Count + 1}";
        }

        if (lineColor == default(Color))
        {
            lineColor = Color.Blue;
        }

        LineSeries lineSeries = new LineSeries(lineName, lineColor, lineWidth, lineStyle);
        AddLineSeries(lineSeries);
        return lineSeries;
    }

    public void AddLineSeries(LineSeries lineSeries)
    {
        if (lineSeries == null)
        {
            throw new ArgumentNullException(C1A5560D_002D169D_002D4815_002DBB20_002D0CA0DFEA0746.봩봪());
        }

        lock (볩볽)
        {
            볩볦.Add(lineSeries);
        }
    }

    public LineLevel AddLineLevel(double level, string lineName = "", Color lineColor = default(Color), int lineWidth = 1, LineStyle lineStyle = LineStyle.Solid)
    {
        if (string.IsNullOrEmpty(lineName))
        {
            lineName = $"{C1A5560D_002D169D_002D4815_002DBB20_002D0CA0DFEA0746.봩봍()}{level}";
        }

        if (lineColor == default(Color))
        {
            lineColor = Color.Blue;
        }

        LineLevel lineLevel = new LineLevel(level, lineName, lineColor, lineWidth, lineStyle);
        AddLineLevel(lineLevel);
        return lineLevel;
    }

    public void AddLineLevel(LineLevel lineLevel)
    {
        if (lineLevel == null)
        {
            throw new ArgumentNullException(C1A5560D_002D169D_002D4815_002DBB20_002D0CA0DFEA0746.봩볢());
        }

        볩봞.Add(lineLevel);
    }

    //
    // Summary:
    //     Recalculate indicator
    public void Refresh()
    {
        ((뵆)HistoricalData)?.봜(this);
    }

    //
    // Parameters:
    //   indicator:
    public void AddIndicator(Indicator indicator)
    {
        if (indicator == null)
        {
            throw new ArgumentNullException(C1A5560D_002D169D_002D4815_002DBB20_002D0CA0DFEA0746.볕봌());
        }

        lock (볩봄)
        {
            if (볩볝.Contains(indicator))
            {
                throw new InvalidOperationException(C1A5560D_002D169D_002D4815_002DBB20_002D0CA0DFEA0746.봩봺());
            }

            indicator.HistoricalData = HistoricalData;
            indicator.Init();
            for (int i = 0; i < Count; i++)
            {
                indicator.Update(new UpdateArgs(UpdateReason.HistoricalBar));
            }

            볩볝.Add(indicator);
        }
    }

    public void RemoveIndicator(Indicator indicator)
    {
        if (indicator == null)
        {
            throw new ArgumentNullException(C1A5560D_002D169D_002D4815_002DBB20_002D0CA0DFEA0746.볕봌());
        }

        lock (볩봄)
        {
            볩볝.Remove(indicator);
        }

        indicator.Clear();
        indicator.Dispose();
    }

    //
    // Summary:
    //     Sets the value of indicator into internal buffer
    //
    // Parameters:
    //   value:
    //     Value
    //
    //   lineIndex:
    //     Index of indicator line
    //
    //   offset:
    //     Offset value
    public void SetValue(double value, int lineIndex = 0, int offset = 0)
    {
        볩볦[lineIndex].SetValue(value, offset);
    }

    //
    // Summary:
    //     Gets the value of indicator from internal buffer
    //
    // Parameters:
    //   offset:
    //     Offset value
    //
    //   lineIndex:
    //     Index of indicator line
    //
    //   origin:
    //     Offset start point
    public double GetValue(int offset = 0, int lineIndex = 0, SeekOriginHistory origin = SeekOriginHistory.End)
    {
        double result = double.NaN;
        if (lineIndex < 0 || lineIndex >= 볩볦.Count)
        {
            return result;
        }

        return 볩볦[lineIndex].GetValue(offset, origin);
    }

    //
    // Summary:
    //     Set line break point.
    //
    // Parameters:
    //   offset:
    //     Offset value
    //
    //   lineIndex:
    //     Index of indicator line
    //
    //   origin:
    //     Offset start point
    public void SetLineBreak(int offset = 0, int lineIndex = 0, SeekOriginHistory origin = SeekOriginHistory.End)
    {
        if (lineIndex < 0 || lineIndex >= 볩볦.Count)
        {
            throw new ArgumentOutOfRangeException(C1A5560D_002D169D_002D4815_002DBB20_002D0CA0DFEA0746.봩볍());
        }

        int lineBreak = ((origin == SeekOriginHistory.End) ? offset : (Count - offset - 1));
        LinesSeries[lineIndex].SetLineBreak(lineBreak);
    }

    //
    // Summary:
    //     Remove line break point.
    //
    // Parameters:
    //   offset:
    //     Offset value
    //
    //   lineIndex:
    //     Index of indicator line
    //
    //   origin:
    //     Offset start point
    public void RemoveLineBreak(int offset = 0, int lineIndex = 0, SeekOriginHistory origin = SeekOriginHistory.End)
    {
        if (lineIndex < 0 || lineIndex >= 볩볦.Count)
        {
            throw new ArgumentOutOfRangeException(C1A5560D_002D169D_002D4815_002DBB20_002D0CA0DFEA0746.봩볍());
        }

        int offset2 = ((origin == SeekOriginHistory.End) ? offset : (Count - offset - 1));
        LinesSeries[lineIndex].RemoveLineBreak(offset2);
    }

    //
    // Summary:
    //     Check if the point is a break point.
    //
    // Parameters:
    //   offset:
    //     Offset value
    //
    //   lineIndex:
    //     Index of indicator line
    //
    //   origin:
    //     Offset start point
    public bool GetLineBreak(int offset = 0, int lineIndex = 0, SeekOriginHistory origin = SeekOriginHistory.End)
    {
        if (lineIndex < 0 || lineIndex >= 볩볦.Count)
        {
            throw new ArgumentOutOfRangeException(C1A5560D_002D169D_002D4815_002DBB20_002D0CA0DFEA0746.봩볍());
        }

        int offset2 = ((origin == SeekOriginHistory.End) ? offset : (Count - offset - 1));
        return LinesSeries[lineIndex].GetLineBreak(offset2);
    }

    //
    // Summary:
    //     Gets the price from historical data
    //
    // Parameters:
    //   priceType:
    //
    //   offset:
    protected double GetPrice(PriceType priceType, int offset = 0)
    {
        return HistoricalData[Count - 1 - offset, SeekOriginHistory.Begin][priceType];
    }

    protected VolumeAnalysisData GetVolumeAnalysisData(int offset = 0)
    {
        return HistoricalData[Count - 1 - offset, SeekOriginHistory.Begin].VolumeAnalysisData;
    }

    //
    // Summary:
    //     Get Bid price
    //
    // Parameters:
    //   offset:
    //     Offset value
    protected double Bid(int offset = 0)
    {
        return GetPrice(PriceType.Bid, offset);
    }

    //
    // Summary:
    //     Get Ask price
    //
    // Parameters:
    //   offset:
    //     Offset value
    protected double Ask(int offset = 0)
    {
        return GetPrice(PriceType.Ask, offset);
    }

    //
    // Summary:
    //     Get Last price
    //
    // Parameters:
    //   offset:
    //     Offset value
    protected double Last(int offset = 0)
    {
        return GetPrice(PriceType.Last, offset);
    }

    //
    // Summary:
    //     Get Open price
    //
    // Parameters:
    //   offset:
    //     Offset value
    protected double Open(int offset = 0)
    {
        return GetPrice(PriceType.Open, offset);
    }

    //
    // Summary:
    //     Get High price
    //
    // Parameters:
    //   offset:
    //     Offset value
    protected double High(int offset = 0)
    {
        return GetPrice(PriceType.High, offset);
    }

    //
    // Summary:
    //     Get Low price
    //
    // Parameters:
    //   offset:
    //     Offset value
    protected double Low(int offset = 0)
    {
        return GetPrice(PriceType.Low, offset);
    }

    //
    // Summary:
    //     Get Close price
    //
    // Parameters:
    //   offset:
    //     Offset value
    protected double Close(int offset = 0)
    {
        return GetPrice(PriceType.Close, offset);
    }

    //
    // Summary:
    //     Get Median price
    //
    // Parameters:
    //   offset:
    //     Offset value
    protected double Median(int offset = 0)
    {
        return GetPrice(PriceType.Median, offset);
    }

    //
    // Summary:
    //     Get Typical price
    //
    // Parameters:
    //   offset:
    //     Offset value
    protected double Typical(int offset = 0)
    {
        return GetPrice(PriceType.Typical, offset);
    }

    //
    // Summary:
    //     Get Weighted price
    //
    // Parameters:
    //   offset:
    //     Offset value
    protected double Weighted(int offset = 0)
    {
        return GetPrice(PriceType.Weighted, offset);
    }

    //
    // Summary:
    //     Get Volume
    //
    // Parameters:
    //   offset:
    //     Offset value
    protected double Volume(int offset = 0)
    {
        return GetPrice(PriceType.Volume, offset);
    }

    //
    // Summary:
    //     Get Volume in quoting asset
    //
    // Parameters:
    //   offset:
    //     Offset value
    protected double QuoteAssetVolume(int offset = 0)
    {
        return GetPrice(PriceType.QuoteAssetVolume, offset);
    }

    //
    // Summary:
    //     Get Ticks
    //
    // Parameters:
    //   offset:
    //     Offset value
    protected double Ticks(int offset = 0)
    {
        return GetPrice(PriceType.Ticks, offset);
    }

    //
    // Summary:
    //     Get Open interest
    //
    // Parameters:
    //   offset:
    //     Offset value
    protected double OpenInterest(int offset = 0)
    {
        return GetPrice(PriceType.OpenInterest, offset);
    }

    //
    // Summary:
    //     Get Funding rate
    //
    // Parameters:
    //   offset:
    //     Offset value
    protected double FundingRate(int offset = 0)
    {
        return GetPrice(PriceType.FundingRate, offset);
    }

    //
    // Summary:
    //     Get Time
    //
    // Parameters:
    //   offset:
    //     Offset value
    protected DateTime Time(int offset = 0)
    {
        return new DateTime(HistoricalData[Count - 1 - offset, SeekOriginHistory.Begin].TicksLeft, DateTimeKind.Utc);
    }

    //
    // Summary:
    //     Formatting price, using precision from assigned symbol or Digits value if specified
    //
    //
    // Parameters:
    //   price:
    //     Price value
    public string FormatPrice(double price)
    {
        if (Digits != -1)
        {
            return price.Format(Digits);
        }

        if (Symbol != null)
        {
            return Symbol.FormatPrice(price);
        }

        return price.ToString();
    }

    [NotPublished]
    public override void Dispose()
    {
        base.Dispose();
        HistoricalData = null;
    }

    public virtual void OnPaintChart(PaintChartEventArgs args)
    {
    }

    public void Calculate(HistoricalData historicalData)
    {
        if (historicalData == null)
        {
            throw new ArgumentNullException(C1A5560D_002D169D_002D4815_002DBB20_002D0CA0DFEA0746.봩뵄());
        }

        HistoricalData?.RemoveIndicator(this);
        historicalData.AddIndicator(this);
    }

    //
    // Summary:
    //     Marks cloud begin between two line series with specific color
    //
    // Parameters:
    //   line1Index:
    //     First line series index
    //
    //   line2Index:
    //     Second line series index
    //
    //   color:
    //     Cloud color
    //
    //   offset:
    //     Offset
    protected void BeginCloud(int line1Index, int line2Index, Color color, int offset = 0)
    {
        IndicatorCloudKey indicatorCloudKey = new IndicatorCloudKey(line1Index, line2Index);
        int num = Count - 1 - offset;
        봜 봜 = this.봜(indicatorCloudKey, num);
        if (봜.EndColor == color)
        {
            봜.EndColor = null;
        }
        else
        {
            봜.BeginColor = color;
        }
    }

    //
    // Summary:
    //     Marks cloud end between two line series with specific color
    //
    // Parameters:
    //   line1Index:
    //     First line series index
    //
    //   line2Index:
    //     Second line series index
    //
    //   color:
    //     Cloud color
    //
    //   offset:
    //     Offset
    protected void EndCloud(int line1Index, int line2Index, Color color, int offset = 0)
    {
        IndicatorCloudKey indicatorCloudKey = new IndicatorCloudKey(line1Index, line2Index);
        int num = Count - 1 - offset;
        봜 봜 = this.봜(indicatorCloudKey, num);
        if (봜.BeginColor == color)
        {
            봜.BeginColor = null;
        }
        else
        {
            봜.EndColor = color;
        }
    }

    private 봜 봜(IndicatorCloudKey P_0, int P_1)
    {
        lock (볩봻)
        {
            if (!볩볞.TryGetValue(P_0, out var value))
            {
                value = (볩볞[P_0] = new List<봜>());
                for (int i = 0; i < Count; i++)
                {
                    value.Add(new 봜());
                }
            }

            봜 봜 = value[P_1];
            if (봜 == null)
            {
                봜 = (value[P_1] = new 봜());
            }

            return 봜;
        }
    }

    [NotPublished]
    public IDictionary<IndicatorCloudKey, IndicatorCloud[]> AnalyzeClouds()
    {
        IDictionary<IndicatorCloudKey, List<봜>> dictionary;
        lock (볩봻)
        {
            if (볩볞.Count == 0)
            {
                return null;
            }

            dictionary = new Dictionary<IndicatorCloudKey, List<봜>>(볩볞);
        }

        Dictionary<IndicatorCloudKey, IndicatorCloud[]> dictionary2 = new Dictionary<IndicatorCloudKey, IndicatorCloud[]>();
        foreach (KeyValuePair<IndicatorCloudKey, List<봜>> item in dictionary)
        {
            IndicatorCloudKey key = item.Key;
            List<봜> value = item.Value;
            List<IndicatorCloud> list = new List<IndicatorCloud>();
            IndicatorCloud indicatorCloud = null;
            for (int i = 0; i < value.Count; i++)
            {
                봜 봜 = value[i];
                if (봜.EndColor.HasValue && indicatorCloud != null)
                {
                    indicatorCloud.ToIndex = i;
                    if (indicatorCloud.ToIndex - indicatorCloud.FromIndex > 0)
                    {
                        indicatorCloud.ToIndex--;
                    }

                    list.Add(indicatorCloud);
                    indicatorCloud = null;
                }

                if (봜.BeginColor.HasValue)
                {
                    indicatorCloud = new IndicatorCloud
                    {
                        Color = 봜.BeginColor.Value,
                        FromIndex = i
                    };
                }
            }

            if (indicatorCloud != null)
            {
                if (indicatorCloud.ToIndex == -1)
                {
                    indicatorCloud.ToIndex = Count - 1;
                }

                list.Add(indicatorCloud);
            }

            dictionary2.Add(key, list.ToArray());
        }

        return dictionary2;
    }

    public void SetBarColor(Color? color = null, int offset = 0)
    {
        int index = 볩볱.Count - 1 - offset;
        if (!color.HasValue)
        {
            볩볱[index] = null;
            return;
        }

        볩볱[index] = new IndicatorBarAppearance
        {
            BarColor = color.Value
        };
    }

    public IndicatorBarAppearance GetBarAppearance(int offset = 0)
    {
        int num = 볩볱.Count - 1 - offset;
        if (num < 0)
        {
            return null;
        }

        return 볩볱[num];
    }

    public void SetBarAppearance(IndicatorBarAppearance barAppearance, int offset = 0)
    {
        int index = 볩볱.Count - 1 - offset;
        볩볱[index] = barAppearance;
    }

    protected virtual bool OnTryGetMinMax(int fromOffset, int toOffset, out double min, out double max)
    {
        min = double.NaN;
        max = double.NaN;
        return false;
    }

    protected Indicator()
    {
        볩볽 = new object();
        볩볦 = new List<LineSeries>();
        볩봞 = new List<LineLevel>();
        볩볝 = new List<Indicator>();
        볩봄 = new object();
        볩볷 = new List<HistoricalDataCustom>();
        볩봟 = new object();
        볩볞 = new Dictionary<IndicatorCloudKey, List<봜>>();
        볩봻 = new object();
        볩볱 = new List<IndicatorBarAppearance>();
    }

    public void Init()
    {
        try
        {
            OnInit();
        }
        catch (Exception ex)
        {
            Core.Instance.Loggers.Log(ex, base.Name + C1A5560D_002D169D_002D4815_002DBB20_002D0CA0DFEA0746.봩봴());
        }
    }

    public void Update(UpdateArgs args)
    {
        if (debugMode)
        {
            while (!base.Disposed)
            {
                Thread.Sleep(100);
                if (볩볼)
                {
                    break;
                }
            }
        }

        bool num = 봜(args.Reason);
        봜(args);
        if (num)
        {
            Count++;
            볾();
            뵆();
        }

        try
        {
            OnUpdate(args);
        }
        catch (Exception ex)
        {
            Core.Instance.Loggers.Log(ex, base.Name + C1A5560D_002D169D_002D4815_002DBB20_002D0CA0DFEA0746.봩봱());
        }

        볩볼 = false;
    }

    public void Clear()
    {
        봗();
        봉();
        Count = 0;
        if (볩볦 == null)
        {
            return;
        }

        lock (볩볽)
        {
            foreach (LineSeries item in 볩볦)
            {
                item.Clear();
            }
        }

        lock (볩봻)
        {
            볩볞.Clear();
        }

        볩볱.Clear();
        try
        {
            OnClear();
        }
        catch (Exception ex)
        {
            Core.Instance.Loggers.Log(ex, base.Name + C1A5560D_002D169D_002D4815_002DBB20_002D0CA0DFEA0746.봩볭());
        }
    }

    public bool TryGetMinMax(int fromOffset, int toOffset, out double min, out double max)
    {
        min = double.NaN;
        max = double.NaN;
        try
        {
            return OnTryGetMinMax(fromOffset, toOffset, out min, out max);
        }
        catch (Exception ex)
        {
            Core.Instance.Loggers.Log(ex, base.Name + C1A5560D_002D169D_002D4815_002DBB20_002D0CA0DFEA0746.봩봀());
        }

        return false;
    }

    public void PaintChart(PaintChartEventArgs ev)
    {
        try
        {
            OnPaintChart(ev);
        }
        catch (Exception ex)
        {
            Core.Instance.Loggers.Log(ex);
        }

        볩볼 = true;
    }

    private bool 봜(UpdateReason P_0)
    {
        switch (P_0)
        {
            case UpdateReason.HistoricalBar:
                return true;
            case UpdateReason.NewBar:
                return true;
            case UpdateReason.NewTick:
                if (HistoricalData.Aggregation == null)
                {
                    return false;
                }

                if (HistoricalData.Aggregation.Name == C1A5560D_002D169D_002D4815_002DBB20_002D0CA0DFEA0746.볕봵() && HistoricalData.Aggregation.GetPeriod == Period.TICK1)
                {
                    return true;
                }

                break;
        }

        return false;
    }

    private void 볾()
    {
        lock (볩볽)
        {
            foreach (LineSeries item in 볩볦)
            {
                item.봜();
            }
        }

        lock (볩볞)
        {
            foreach (KeyValuePair<IndicatorCloudKey, List<봜>> item2 in 볩볞)
            {
                item2.Value.Add(new 봜());
            }
        }

        볩볱.Add(null);
    }

    private void 봜(UpdateArgs P_0)
    {
        lock (볩봄)
        {
            foreach (Indicator item in 볩볝)
            {
                item.Update(P_0);
            }
        }
    }

    private void 봗()
    {
        lock (볩봄)
        {
            foreach (Indicator item in 볩볝)
            {
                item.Clear();
                item.Dispose();
            }

            볩볝.Clear();
        }
    }

    internal void 봜(HistoricalDataCustom P_0)
    {
        if (P_0 == null)
        {
            throw new ArgumentNullException(C1A5560D_002D169D_002D4815_002DBB20_002D0CA0DFEA0746.봩봢());
        }

        lock (볩봟)
        {
            if (볩볷.Contains(P_0))
            {
                throw new InvalidOperationException(C1A5560D_002D169D_002D4815_002DBB20_002D0CA0DFEA0746.봩봚());
            }

            for (int i = 0; i < Count; i++)
            {
                P_0.볾();
            }

            볩볷.Add(P_0);
        }
    }

    private void 뵆()
    {
        lock (볩봟)
        {
            foreach (HistoricalDataCustom item in 볩볷)
            {
                item.볾();
            }
        }
    }

    private void 봉()
    {
        lock (볩봟)
        {
            foreach (HistoricalDataCustom item in 볩볷)
            {
                item.Dispose();
            }

            볩볷.Clear();
        }
    }

    protected override void OnSettingsUpdated()
    {
        Refresh();
    }
}
#if false // Decompilation log
'164' items in cache
------------------
Resolve: 'System.Runtime, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Runtime, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.16\ref\net8.0\System.Runtime.dll'
------------------
Resolve: 'AuthenticodeExaminer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'
Could not find by name: 'AuthenticodeExaminer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'
------------------
Resolve: 'System.Security.Cryptography, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Security.Cryptography, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.16\ref\net8.0\System.Security.Cryptography.dll'
------------------
Resolve: 'System.ComponentModel.Primitives, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.ComponentModel.Primitives, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.16\ref\net8.0\System.ComponentModel.Primitives.dll'
------------------
Resolve: 'System.Collections, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Collections, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.16\ref\net8.0\System.Collections.dll'
------------------
Resolve: 'System.Runtime.Serialization.Primitives, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Runtime.Serialization.Primitives, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.16\ref\net8.0\System.Runtime.Serialization.Primitives.dll'
------------------
Resolve: 'protobuf-net.Core, Version=3.0.0.0, Culture=neutral, PublicKeyToken=257b51d87d2e4d67'
Could not find by name: 'protobuf-net.Core, Version=3.0.0.0, Culture=neutral, PublicKeyToken=257b51d87d2e4d67'
------------------
Resolve: 'System.Xml.XDocument, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Xml.XDocument, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.16\ref\net8.0\System.Xml.XDocument.dll'
------------------
Resolve: 'System.Threading, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Threading, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.16\ref\net8.0\System.Threading.dll'
------------------
Resolve: 'System.Drawing.Primitives, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Drawing.Primitives, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.16\ref\net8.0\System.Drawing.Primitives.dll'
------------------
Resolve: 'System.Linq, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Linq, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.16\ref\net8.0\System.Linq.dll'
------------------
Resolve: 'System.Collections.Concurrent, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Collections.Concurrent, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.16\ref\net8.0\System.Collections.Concurrent.dll'
------------------
Resolve: 'FluentFTP, Version=51.1.0.0, Culture=neutral, PublicKeyToken=f4af092b1d8df44f'
Could not find by name: 'FluentFTP, Version=51.1.0.0, Culture=neutral, PublicKeyToken=f4af092b1d8df44f'
------------------
Resolve: 'IdentityModel.OidcClient, Version=6.0.0.0, Culture=neutral, PublicKeyToken=5580d04c1b6c37c1'
Could not find by name: 'IdentityModel.OidcClient, Version=6.0.0.0, Culture=neutral, PublicKeyToken=5580d04c1b6c37c1'
------------------
Resolve: 'System.Collections.Specialized, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Collections.Specialized, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.16\ref\net8.0\System.Collections.Specialized.dll'
------------------
Resolve: 'System.Net.Http, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Net.Http, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.16\ref\net8.0\System.Net.Http.dll'
------------------
Resolve: 'IdentityModel, Version=7.0.0.0, Culture=neutral, PublicKeyToken=e7877f4675df049f'
Could not find by name: 'IdentityModel, Version=7.0.0.0, Culture=neutral, PublicKeyToken=e7877f4675df049f'
------------------
Resolve: 'System.Drawing.Common, Version=8.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Could not find by name: 'System.Drawing.Common, Version=8.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
------------------
Resolve: 'System.IO.FileSystem.Watcher, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.IO.FileSystem.Watcher, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.16\ref\net8.0\System.IO.FileSystem.Watcher.dll'
------------------
Resolve: 'System.Diagnostics.DiagnosticSource, Version=8.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Found single assembly: 'System.Diagnostics.DiagnosticSource, Version=8.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.16\ref\net8.0\System.Diagnostics.DiagnosticSource.dll'
------------------
Resolve: 'System.Xml.ReaderWriter, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Xml.ReaderWriter, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.16\ref\net8.0\System.Xml.ReaderWriter.dll'
------------------
Resolve: 'CommandLine, Version=2.9.1.0, Culture=neutral, PublicKeyToken=5a870481e358d379'
Could not find by name: 'CommandLine, Version=2.9.1.0, Culture=neutral, PublicKeyToken=5a870481e358d379'
------------------
Resolve: 'System.Net.Mail, Version=8.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Found single assembly: 'System.Net.Mail, Version=8.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.16\ref\net8.0\System.Net.Mail.dll'
------------------
Resolve: 'NGettext, Version=0.6.1.0, Culture=neutral, PublicKeyToken=08d3d1c89dfd2985'
Could not find by name: 'NGettext, Version=0.6.1.0, Culture=neutral, PublicKeyToken=08d3d1c89dfd2985'
------------------
Resolve: 'System.Net.Sockets, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Net.Sockets, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.16\ref\net8.0\System.Net.Sockets.dll'
------------------
Resolve: 'System.Net.Primitives, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Net.Primitives, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.16\ref\net8.0\System.Net.Primitives.dll'
------------------
Resolve: 'System.ObjectModel, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.ObjectModel, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.16\ref\net8.0\System.ObjectModel.dll'
------------------
Resolve: 'System.Text.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Found single assembly: 'System.Text.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.16\ref\net8.0\System.Text.Json.dll'
------------------
Resolve: 'System.Collections.Immutable, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Collections.Immutable, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.16\ref\net8.0\System.Collections.Immutable.dll'
------------------
Resolve: 'System.Net.Requests, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Net.Requests, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.16\ref\net8.0\System.Net.Requests.dll'
------------------
Resolve: 'System.Net.HttpListener, Version=8.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Found single assembly: 'System.Net.HttpListener, Version=8.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.16\ref\net8.0\System.Net.HttpListener.dll'
------------------
Resolve: 'System.Net.NetworkInformation, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Net.NetworkInformation, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.16\ref\net8.0\System.Net.NetworkInformation.dll'
------------------
Resolve: 'System.Security.Claims, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Security.Claims, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.16\ref\net8.0\System.Security.Claims.dll'
------------------
Resolve: 'System.Text.RegularExpressions, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Text.RegularExpressions, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.16\ref\net8.0\System.Text.RegularExpressions.dll'
------------------
Resolve: 'System.Net.Ping, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Net.Ping, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.16\ref\net8.0\System.Net.Ping.dll'
------------------
Resolve: 'System.Web.HttpUtility, Version=8.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Found single assembly: 'System.Web.HttpUtility, Version=8.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.16\ref\net8.0\System.Web.HttpUtility.dll'
------------------
Resolve: 'System.Threading.Thread, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Threading.Thread, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.16\ref\net8.0\System.Threading.Thread.dll'
------------------
Resolve: 'System.Net.ServicePoint, Version=8.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Found single assembly: 'System.Net.ServicePoint, Version=8.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.16\ref\net8.0\System.Net.ServicePoint.dll'
------------------
Resolve: 'System.Runtime.InteropServices, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Runtime.InteropServices, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.16\ref\net8.0\System.Runtime.InteropServices.dll'
------------------
Resolve: 'System.Net.NameResolution, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Net.NameResolution, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.16\ref\net8.0\System.Net.NameResolution.dll'
------------------
Resolve: 'System.Runtime.Serialization.Formatters, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Runtime.Serialization.Formatters, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.16\ref\net8.0\System.Runtime.Serialization.Formatters.dll'
------------------
Resolve: 'System.Xml.XPath.XDocument, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Xml.XPath.XDocument, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.16\ref\net8.0\System.Xml.XPath.XDocument.dll'
------------------
Resolve: 'System.Threading.ThreadPool, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Threading.ThreadPool, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.16\ref\net8.0\System.Threading.ThreadPool.dll'
------------------
Resolve: 'System.Net.Http.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Found single assembly: 'System.Net.Http.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.16\ref\net8.0\System.Net.Http.Json.dll'
------------------
Resolve: 'System.Diagnostics.Process, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Diagnostics.Process, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.16\ref\net8.0\System.Diagnostics.Process.dll'
------------------
Resolve: 'System.Net.WebHeaderCollection, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Net.WebHeaderCollection, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.16\ref\net8.0\System.Net.WebHeaderCollection.dll'
------------------
Resolve: 'System.Runtime.CompilerServices.Unsafe, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null'
Found single assembly: 'System.Runtime.CompilerServices.Unsafe, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.16\ref\net8.0\System.Runtime.CompilerServices.Unsafe.dll'
#endif
