#region Assembly TradingPlatform.BusinessLayer, Version=1.0.96.0, Culture=neutral, PublicKeyToken=null
// C:\Application Files\Quantower\Quantower.in\TradingPlatform\v1.0.96\bin\TradingPlatform.BusinessLayer.dll
// Decompiled with ICSharpCode.Decompiler 8.2.0.7535
#endregion

using System;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B97AB1A55_002DA700_002D43FC_002D9501_002D183BC14A3746_007D;
using ProtoBuf;

namespace TradingPlatform.BusinessLayer;

//
// Summary:
//     Represents historical data bar item
[Published]
[ProtoContract]
public class HistoryItemBar : HistoryItem
{
    [CompilerGenerated]
    private long 볹볝;

    [CompilerGenerated]
    private double 볹봄;

    [CompilerGenerated]
    private double 볹볷;

    [CompilerGenerated]
    private double 볹봟;

    [CompilerGenerated]
    private double 볹볼;

    [CompilerGenerated]
    private long 볹볞;

    [CompilerGenerated]
    private double 볹봻;

    [CompilerGenerated]
    private double 볹볱;

    [CompilerGenerated]
    private double 볹봑;

    [CompilerGenerated]
    private double 볹봬;

    //
    // Summary:
    //     Gets bar's right time border
    public DateTime TimeRight => new DateTime(TicksRight, DateTimeKind.Utc);

    //
    // Summary:
    //     Defines bar's ticks count
    public override long TicksRight
    {
        [CompilerGenerated]
        get
        {
            return 볹볝;
        }
        [CompilerGenerated]
        set
        {
            볹볝 = value;
        }
    }

    //
    // Summary:
    //     Defines Open price
    [ProtoMember(1)]
    public double Open
    {
        [CompilerGenerated]
        get
        {
            return 볹봄;
        }
        [CompilerGenerated]
        set
        {
            볹봄 = value;
        }
    }

    //
    // Summary:
    //     Defines High price
    [ProtoMember(2)]
    public double High
    {
        [CompilerGenerated]
        get
        {
            return 볹볷;
        }
        [CompilerGenerated]
        set
        {
            볹볷 = value;
        }
    }

    //
    // Summary:
    //     Defines Low price
    [ProtoMember(3)]
    public double Low
    {
        [CompilerGenerated]
        get
        {
            return 볹봟;
        }
        [CompilerGenerated]
        set
        {
            볹봟 = value;
        }
    }

    //
    // Summary:
    //     Defines Close price
    [ProtoMember(4)]
    public double Close
    {
        [CompilerGenerated]
        get
        {
            return 볹볼;
        }
        [CompilerGenerated]
        set
        {
            볹볼 = value;
        }
    }

    //
    // Summary:
    //     Gets Median (High+Low)/2 price
    public double Median => (High + Low) / 2.0;

    //
    // Summary:
    //     Gets Typical (High+Low+Close)/3 price
    public double Typical => (High + Low + Close) / 3.0;

    //
    // Summary:
    //     Gets Weighted (High+Low+Close+Close)/4 price
    public double Weighted => (High + Low + Close + Close) / 4.0;

    //
    // Summary:
    //     Defines ticks amount
    [ProtoMember(5)]
    public long Ticks
    {
        [CompilerGenerated]
        get
        {
            return 볹볞;
        }
        [CompilerGenerated]
        set
        {
            볹볞 = value;
        }
    }

    //
    // Summary:
    //     Defines volume value
    [ProtoMember(6)]
    public double Volume
    {
        [CompilerGenerated]
        get
        {
            return 볹봻;
        }
        [CompilerGenerated]
        set
        {
            볹봻 = value;
        }
    }

    [ProtoMember(7)]
    public double OpenInterest
    {
        [CompilerGenerated]
        get
        {
            return 볹볱;
        }
        [CompilerGenerated]
        set
        {
            볹볱 = value;
        }
    }

    [ProtoMember(8)]
    public double FundingRate
    {
        [CompilerGenerated]
        get
        {
            return 볹봑;
        }
        [CompilerGenerated]
        set
        {
            볹봑 = value;
        }
    }

    [ProtoMember(9)]
    public double QuoteAssetVolume
    {
        [CompilerGenerated]
        get
        {
            return 볹봬;
        }
        [CompilerGenerated]
        set
        {
            볹봬 = value;
        }
    }

    //
    // Summary:
    //     Gets price by indexing TradingPlatform.BusinessLayer.PriceType
    //
    // Parameters:
    //   priceType:
    public override double this[PriceType priceType] => priceType switch
    {
        PriceType.Open => Open,
        PriceType.High => High,
        PriceType.Low => Low,
        PriceType.Close => Close,
        PriceType.Median => Median,
        PriceType.Typical => Typical,
        PriceType.Weighted => Weighted,
        PriceType.Ticks => Ticks,
        PriceType.Volume => Volume,
        PriceType.OpenInterest => OpenInterest,
        PriceType.FundingRate => FundingRate,
        PriceType.QuoteAssetVolume => QuoteAssetVolume,
        _ => base[priceType],
    };

    //
    // Summary:
    //     Creates HistoryItemBar instance with default OHLC price = TradingPlatform.BusinessLayer.Utils.Const.DOUBLE_UNDEFINED
    public HistoryItemBar()
    {
        Open = double.NaN;
        High = double.NaN;
        Low = double.NaN;
        Close = double.NaN;
    }

    //
    // Summary:
    //     Comparing by TradingPlatform.BusinessLayer.HistoryItem.TicksLeft, OHLC, TradingPlatform.BusinessLayer.HistoryItemBar.Volume
    //
    //
    // Parameters:
    //   obj:
    [NotPublished]
    public override bool Equals(object obj)
    {
        HistoryItemBar historyItemBar = obj as HistoryItemBar;
        if (historyItemBar == null)
        {
            return false;
        }

        if (base.TicksLeft == historyItemBar.TicksLeft && Open == historyItemBar.Open && High == historyItemBar.High && Low == historyItemBar.Low && Close == historyItemBar.Close && Ticks == historyItemBar.Ticks && Volume == historyItemBar.Volume)
        {
            return QuoteAssetVolume == historyItemBar.QuoteAssetVolume;
        }

        return false;
    }

    [NotPublished]
    public override int GetHashCode()
    {
        return base.TicksLeft.GetHashCode() ^ Open.GetHashCode() ^ High.GetHashCode() ^ Low.GetHashCode() ^ Close.GetHashCode() ^ Ticks.GetHashCode() ^ Volume.GetHashCode() ^ QuoteAssetVolume.GetHashCode();
    }

    [NotPublished]
    public static bool operator ==(HistoryItemBar a, HistoryItemBar b)
    {
        if ((object)a == b)
        {
            return true;
        }

        if ((object)a == null || (object)b == null)
        {
            return false;
        }

        return a.Equals(b);
    }

    [NotPublished]
    public static bool operator !=(HistoryItemBar a, HistoryItemBar b)
    {
        return !(a == b);
    }

    [NotPublished]
    public override string ToString()
    {
        DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(39, 10);
        defaultInterpolatedStringHandler.AppendFormatted(base.TicksLeft);
        defaultInterpolatedStringHandler.AppendLiteral(C1A5560D_002D169D_002D4815_002DBB20_002D0CA0DFEA0746.볾봈());
        defaultInterpolatedStringHandler.AppendFormatted(TicksRight);
        defaultInterpolatedStringHandler.AppendLiteral(C1A5560D_002D169D_002D4815_002DBB20_002D0CA0DFEA0746.봩볥());
        defaultInterpolatedStringHandler.AppendFormatted(Ticks);
        defaultInterpolatedStringHandler.AppendLiteral(C1A5560D_002D169D_002D4815_002DBB20_002D0CA0DFEA0746.봩볟());
        defaultInterpolatedStringHandler.AppendFormatted(base.TimeLeft);
        defaultInterpolatedStringHandler.AppendLiteral(C1A5560D_002D169D_002D4815_002DBB20_002D0CA0DFEA0746.볾봈());
        defaultInterpolatedStringHandler.AppendFormatted(TimeRight);
        defaultInterpolatedStringHandler.AppendLiteral(C1A5560D_002D169D_002D4815_002DBB20_002D0CA0DFEA0746.봩봣());
        defaultInterpolatedStringHandler.AppendFormatted(Open);
        defaultInterpolatedStringHandler.AppendLiteral(C1A5560D_002D169D_002D4815_002DBB20_002D0CA0DFEA0746.봩봌());
        defaultInterpolatedStringHandler.AppendFormatted(High);
        defaultInterpolatedStringHandler.AppendLiteral(C1A5560D_002D169D_002D4815_002DBB20_002D0CA0DFEA0746.봩봯());
        defaultInterpolatedStringHandler.AppendFormatted(Low);
        defaultInterpolatedStringHandler.AppendLiteral(C1A5560D_002D169D_002D4815_002DBB20_002D0CA0DFEA0746.봩봹());
        defaultInterpolatedStringHandler.AppendFormatted(Close);
        defaultInterpolatedStringHandler.AppendLiteral(C1A5560D_002D169D_002D4815_002DBB20_002D0CA0DFEA0746.봗봆());
        defaultInterpolatedStringHandler.AppendFormatted((Close > Open) ? C1A5560D_002D169D_002D4815_002DBB20_002D0CA0DFEA0746.봩봆() : C1A5560D_002D169D_002D4815_002DBB20_002D0CA0DFEA0746.봩볮());
        return defaultInterpolatedStringHandler.ToStringAndClear();
    }

    private HistoryItemBar(HistoryItemBar P_0)
        : base(P_0)
    {
        TicksRight = P_0.TicksRight;
        Open = P_0.Open;
        High = P_0.High;
        Low = P_0.Low;
        Close = P_0.Close;
        Ticks = P_0.Ticks;
        Volume = P_0.Volume;
        OpenInterest = P_0.OpenInterest;
        FundingRate = P_0.FundingRate;
        QuoteAssetVolume = P_0.QuoteAssetVolume;
        base.VolumeAnalysisData = P_0.VolumeAnalysisData;
    }

    [NotPublished]
    public override object Clone()
    {
        return new HistoryItemBar(this);
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
