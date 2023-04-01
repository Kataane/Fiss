namespace Fiss;

/// <summary>
///     Market trading modes
/// </summary>
public enum Board : ushort
{
    /// <summary>
    ///     Agro: NAMEX Buy auctions
    /// </summary>
    ABGR,

    /// <summary>
    ///     Deposits with CCP – Auction
    /// </summary>
    ADEP,

    /// <summary>
    ///     NAMEX indices
    /// </summary>
    AGRO,

    /// <summary>
    ///     Agro: NAMEX Auctions
    /// </summary>
    AIGR,

    /// <summary>
    ///     Buyback: Auction - order-driven
    /// </summary>
    AUBB,

    /// <summary>
    ///     Auction CBR - negotiated
    /// </summary>
    AUCB,

    /// <summary>
    ///     Issuance: Auction - order-driven
    /// </summary>
    AUCT,

    /// <summary>
    ///     System deals - order-driven
    /// </summary>
    CETS,

    /// <summary>
    ///     Neg. CCP settle's Deals: Non-residents - order-driven
    /// </summary>
    CIQB,

    /// <summary>
    ///     REPO CCP settle's Deals : Non-residents - order-driven
    /// </summary>
    CIQR,

    /// <summary>
    ///     Classica - negotiated
    /// </summary>
    CLAD,

    /// <summary>
    ///     Classica - order-driven
    /// </summary>
    CLMR,

    /// <summary>
    ///     Negotiated deals - negotiated
    /// </summary>
    CNGD,

    /// <summary>
    ///     REPO-M: Non-residents (EUR) - negotiated
    /// </summary>
    CPEO,

    /// <summary>
    ///     REPO-M: Non-residents (USD) - negotiated
    /// </summary>
    CPEU,

    /// <summary>
    ///     REPO-M: Non-residents (CNY) - negotiated
    /// </summary>
    CPEY,

    /// <summary>
    ///     REPO-M: Non-residents - negotiated
    /// </summary>
    CPMO,

    /// <summary>
    ///     Credits EUR - negotiated
    /// </summary>
    CREE,

    /// <summary>
    ///     Credits RUB - negotiated
    /// </summary>
    CRER,

    /// <summary>
    ///     Credits USD - negotiated
    /// </summary>
    CREU,

    /// <summary>
    ///     Credits USD - negotiated
    /// </summary>
    CREY,

    /// <summary>
    ///     Neg. deals CCP Non-residents: Stocks, DRs - negotiated
    /// </summary>
    CTEQ,

    /// <summary>
    ///     Neg. deals CCP Non-residents: Bonds - negotiated
    /// </summary>
    CTOB,

    /// <summary>
    ///     Neg. deals CCP Non-residents: Bonds (USD) - negotiated
    /// </summary>
    CTOD,

    /// <summary>
    ///     Neg. deals CCP: Non-residents: Bonds (EUR) - negotiated
    /// </summary>
    CTOE,

    /// <summary>
    ///     Neg. deals CCP Non-residents: Bonds (CNY) - negotiated
    /// </summary>
    CTOY,

    /// <summary>
    ///     Neg. deals CCP Non-residents: Stocks, DRs (USD) - negotiated
    /// </summary>
    CTSD,

    /// <summary>
    ///     Neg. deals CCP Non-residents: Stocks, DRs (EUR) - negotiated
    /// </summary>
    CTSE,

    /// <summary>
    ///     Day session
    /// </summary>
    CURR,

    /// <summary>
    ///     Main market: A1 stocks - order-driven
    /// </summary>
    EQBR,

    /// <summary>
    ///     Main market: A2 stocks - order-driven
    /// </summary>
    EQBS,

    /// <summary>
    ///     Trades with Central counterpary - order-driven
    /// </summary>
    EQCC,

    /// <summary>
    ///     Main market: Bonds D - order-driven
    /// </summary>
    EQDB,

    /// <summary>
    ///     Main market: D stocks - order-driven
    /// </summary>
    EQDE,

    /// <summary>
    ///     Dark pool: stocks - order-driven
    /// </summary>
    EQDP,

    /// <summary>
    ///     Main market: bonds (EUR) - order-driven
    /// </summary>
    EQEO,

    /// <summary>
    ///     Main market: bonds (USD) - order-driven
    /// </summary>
    EQEU,

    /// <summary>
    ///     Main market: bonds (GBP) - order-driven
    /// </summary>
    EQGO,

    /// <summary>
    ///     Main market: I stocks - order-driven
    /// </summary>
    EQLI,

    /// <summary>
    ///     Main market: V stocks - order-driven
    /// </summary>
    EQLV,

    /// <summary>
    ///     REPO CCP 1 month (USD) - order-driven
    /// </summary>
    EQMD,

    /// <summary>
    ///     REPO CCP 1 month (EUR) - order-driven
    /// </summary>
    EQME,

    /// <summary>
    ///     REPO CCP 1 month (RUB) - order-driven
    /// </summary>
    EQMP,

    /// <summary>
    ///     REPO with CCP 1 month (CNY) - order-driven
    /// </summary>
    EQMY,

    /// <summary>
    ///     Main market: not listed bonds - order-driven
    /// </summary>
    EQNB,

    /// <summary>
    ///     Main market: not listed stocks - order-driven
    /// </summary>
    EQNE,

    /// <summary>
    ///     Main market: B stocks - order-driven
    /// </summary>
    EQNL,

    /// <summary>
    ///     Main market: B bonds - order-driven
    /// </summary>
    EQNO,

    /// <summary>
    ///     Main market: A1 bonds - order-driven
    /// </summary>
    EQOB,

    /// <summary>
    ///     Main market: A2 bonds - order-driven
    /// </summary>
    EQOS,

    /// <summary>
    ///     Main market: V bonds - order-driven
    /// </summary>
    EQOV,

    /// <summary>
    ///     Main trading mode: for qualified investors - order-driven
    /// </summary>
    EQQI,

    /// <summary>
    ///     REPO with CCP 1 day (USD) - order-driven
    /// </summary>
    EQRD,

    /// <summary>
    ///     REPO with CCP 1 day (EUR) - order-driven
    /// </summary>
    EQRE,

    /// <summary>
    ///     REPO with CCP 1 day - order-driven
    /// </summary>
    EQRP,

    /// <summary>
    ///     REPO CCP 1 day (CNY) - order-driven
    /// </summary>
    EQRY,

    /// <summary>
    ///     T0 ETC - order-driven
    /// </summary>
    EQTC,

    /// <summary>
    ///     T0: ETF (USD) - order-driven
    /// </summary>
    EQTD,

    /// <summary>
    ///     REPO CCP 3 months (EUR) - order-driven
    /// </summary>
    EQTE,

    /// <summary>
    ///     REPO CCP 3 months (RUB) - order-driven
    /// </summary>
    EQTP,

    /// <summary>
    ///     T0: ETF (EUR) - order-driven
    /// </summary>
    EQTU,

    /// <summary>
    ///     REPO CCP 3 months (CNY) - order-driven
    /// </summary>
    EQTY,

    /// <summary>
    ///     Main market: Off-list bonds - order-driven
    /// </summary>
    EQUS,

    /// <summary>
    ///     REPO with CCP 7 day (USD) - order-driven
    /// </summary>
    EQWD,

    /// <summary>
    ///     REPO with CCP 7 day (EUR) - order-driven
    /// </summary>
    EQWE,

    /// <summary>
    ///     REPO with CCP 7 day - order-driven
    /// </summary>
    EQWP,

    /// <summary>
    ///     REPO with CCP 7 day (CNY) - order-driven
    /// </summary>
    EQWY,

    /// <summary>
    ///     Main market: bonds (CNY) - order-driven
    /// </summary>
    EQYO,

    /// <summary>
    ///     REPO CCP 3 months (USD) - order-driven
    /// </summary>
    ETQD,

    /// <summary>
    ///     REPO with CCP with GCP fl. 9m - order-driven (RUSFAR)
    /// </summary>
    FCNM,

    /// <summary>
    ///     REPO with CCP with GCP fl. 1m - order-driven (RUSFAR)
    /// </summary>
    FCOM,

    /// <summary>
    ///     REPO with CCP with GCP fl. 7d - order-driven (RUSFAR)
    /// </summary>
    FCOW,

    /// <summary>
    ///     REPO with CCP with GCP fl. 1y - order-driven (RUSFAR)
    /// </summary>
    FCOY,

    /// <summary>
    ///     REPO with CCP with GCP fl. 2m - order-driven (RUSFAR)
    /// </summary>
    FCSM,

    /// <summary>
    ///     REPO with CCP with GCP fl. 14d - order-driven (RUSFAR)
    /// </summary>
    FCSW,

    /// <summary>
    ///     REPO with CCP with GCP fl. 3m - order-driven (RUSFAR)
    /// </summary>
    FCTM,

    /// <summary>
    ///     REPO with CCP with GCP fl. 6m - order-driven (RUSFAR)
    /// </summary>
    FCUM,

    /// <summary>
    ///     Futures IQS
    /// </summary>
    FIQS,

    /// <summary>
    ///     Currency fixing
    /// </summary>
    FIXI,

    /// <summary>
    ///     Negotiated fixing - negotiated
    /// </summary>
    FIXN,

    /// <summary>
    ///     System fixing - order-driven
    /// </summary>
    FIXS,

    /// <summary>
    ///     Auction with CCP 5 weeks - order-driven
    /// </summary>
    FKFW,

    /// <summary>
    ///     Auction with CCP 1 month - order-driven
    /// </summary>
    FKOM,

    /// <summary>
    ///     Auction with CCP 1 week - order-driven
    /// </summary>
    FKOW,

    /// <summary>
    ///     Auction with CCP 1 year - order-driven
    /// </summary>
    FKOY,

    /// <summary>
    ///     Auction with CCP overnight - order-driven
    /// </summary>
    FKRP,

    /// <summary>
    ///     Auction with CCP 2 months - order-driven
    /// </summary>
    FKSM,

    /// <summary>
    ///     Auction with CCP 2 weeks - order-driven
    /// </summary>
    FKSW,

    /// <summary>
    ///     Auction with CCP 3 months - order-driven
    /// </summary>
    FKTM,

    /// <summary>
    ///     Auction with CCP 6 months - order-driven
    /// </summary>
    FKUM,

    /// <summary>
    ///     Futures and Options
    /// </summary>
    FOB,

    /// <summary>
    ///     Commodity futures
    /// </summary>
    FOCM,

    /// <summary>
    ///     T+: FRGN stocks, DRs HKD - order-driven
    /// </summary>
    FQBH,

    /// <summary>
    ///     T+: FRGN stocks, DRs - order-driven
    /// </summary>
    FQBR,

    /// <summary>
    ///     T+: FRGN stocks, DRs CNY - order-driven
    /// </summary>
    FQBY,

    /// <summary>
    ///     T+: inv. risk stocks FRGN - order-driven
    /// </summary>
    FQDE,

    /// <summary>
    ///     T+: inv. risk stocks FRGN HKD - order-driven
    /// </summary>
    FQDH,

    /// <summary>
    ///     T+: inv. risk stocks FRGN CNY - order-driven
    /// </summary>
    FQDY,

    /// <summary>
    ///     Auction REPO with CCP 5 weeks - order-driven
    /// </summary>
    FRFW,

    /// <summary>
    ///     Auction REPO with CCP 1 month - order-driven
    /// </summary>
    FROM,

    /// <summary>
    ///     Auction REPO with CCP 1 week - order-driven
    /// </summary>
    FROW,

    /// <summary>
    ///     Auction REPO with CCP overnight - order-driven
    /// </summary>
    FRRP,

    /// <summary>
    ///     Auction REPO with CCP 2 weeks - order-driven
    /// </summary>
    FRSW,

    /// <summary>
    ///     Auction REPO with CCP 3 months - order-driven
    /// </summary>
    FRTM,

    /// <summary>
    ///     Neg. deals: inv. risk stocks FRGN - negotiated
    /// </summary>
    FSDE,

    /// <summary>
    ///     Neg deals: i rsk stck FRGN HKD - negotiated
    /// </summary>
    FSDH,

    /// <summary>
    ///     Neg deals: i rsk stck FRGN CNY - negotiated
    /// </summary>
    FSDY,

    /// <summary>
    ///     Neg. deals: FRGN stocks - negotiated
    /// </summary>
    FSEQ,

    /// <summary>
    ///     Auction w/reverse CCP 5 weeks - order-driven
    /// </summary>
    FSFW,

    /// <summary>
    ///     Auction w/reverse CCP 1 month - order-driven
    /// </summary>
    FSOM,

    /// <summary>
    ///     Auction w/reverse CCP 1 week - order-driven
    /// </summary>
    FSOW,

    /// <summary>
    ///     Auction w/reverse CCP 1 day - order-driven
    /// </summary>
    FSRP,

    /// <summary>
    ///     Neg. deals: FRGN stocks HKD - negotiated
    /// </summary>
    FSSH,

    /// <summary>
    ///     Auction w/reverse CCP 2 weeks - order-driven
    /// </summary>
    FSSW,

    /// <summary>
    ///     Neg. deals: FRGN stocks CNY - negotiated
    /// </summary>
    FSSY,

    /// <summary>
    ///     NDM with CCP: inv. risk stocks FRGN - negotiated
    /// </summary>
    FTDE,

    /// <summary>
    ///     NDM w/CCP: FRGN stck, DRs HKD - negotiated
    /// </summary>
    FTDH,

    /// <summary>
    ///     NDM w/CCP: FRGN stck, DRs CNY - negotiated
    /// </summary>
    FTDY,

    /// <summary>
    ///     NDM with CCP: FRGN stocks, DRs - negotiated
    /// </summary>
    FTEQ,

    /// <summary>
    ///     NDM w/CCP: FRGN stck, DRs HKD - negotiated
    /// </summary>
    FTSH,

    /// <summary>
    ///     NDM w/CCP: FRGN stck, DRs CNY - negotiated
    /// </summary>
    FTSY,

    /// <summary>
    ///     Negotiated futures - negotiated
    /// </summary>
    FUTN,

    /// <summary>
    ///     System futures - order-driven
    /// </summary>
    FUTS,

    /// <summary>
    ///     REPO with CCP with GCP fl. 9m (CNY) - order-driven (RUSFARCNY)
    /// </summary>
    FYNM,

    /// <summary>
    ///     REPO with CCP with GCP fl. 1m (CNY) - order-driven (RUSFARCNY)
    /// </summary>
    FYOM,

    /// <summary>
    ///     REPO with CCP with GCP fl. 7d (CNY) - order-driven (RUSFARCNY)
    /// </summary>
    FYOW,

    /// <summary>
    ///     REPO with CCP with GCP fl. 1y (CNY) - order-driven (RUSFARCNY)
    /// </summary>
    FYOY,

    /// <summary>
    ///     REPO with CCP with GCP fl. 2m (CNY) - order-driven (RUSFARCNY)
    /// </summary>
    FYSM,

    /// <summary>
    ///     REPO with CCP with GCP fl. 14d (CNY) - order-driven (RUSFARCNY)
    /// </summary>
    FYSW,

    /// <summary>
    ///     REPO with CCP with GCP fl. 3m (CNY) - order-driven (RUSFARCNY)
    /// </summary>
    FYTM,

    /// <summary>
    ///     REPO with CCP with GCP fl. 6m (CNY) - order-driven (RUSFARCNY)
    /// </summary>
    FYUM,

    /// <summary>
    ///     REPO CCP 9 months (RUB) - order-driven
    /// </summary>
    GCNM,

    /// <summary>
    ///     REPO CCP GCC 1 month - order-driven
    /// </summary>
    GCOM,

    /// <summary>
    ///     REPO CCP GCC 7 days - order-driven
    /// </summary>
    GCOW,

    /// <summary>
    ///     REPO CCP GCC 1 year - order-driven
    /// </summary>
    GCOY,

    /// <summary>
    ///     REPO CCP GCC 1 day - order-driven
    /// </summary>
    GCRP,

    /// <summary>
    ///     REPO CCP GCC 2 months - order-driven
    /// </summary>
    GCSM,

    /// <summary>
    ///     REPO CCP GCC 14 days - order-driven
    /// </summary>
    GCSW,

    /// <summary>
    ///     REPO CCP GCC 3 months - order-driven
    /// </summary>
    GCTM,

    /// <summary>
    ///     REPO CCP GCC 6 months - order-driven
    /// </summary>
    GCUM,

    /// <summary>
    ///     REPO CCP 9 months (EUR) - order-driven
    /// </summary>
    GENM,

    /// <summary>
    ///     REPO CCP GCC 1 month (EUR) - order-driven
    /// </summary>
    GEOM,

    /// <summary>
    ///     REPO CCP GCC 7 days (EUR) - order-driven
    /// </summary>
    GEOW,

    /// <summary>
    ///     REPO CCP GCC 1 year (EUR) - order-driven
    /// </summary>
    GEOY,

    /// <summary>
    ///     REPO CCP GCC 1 day (EUR) - order-driven
    /// </summary>
    GERP,

    /// <summary>
    ///     REPO CCP GCC 2 months (EUR) - order-driven
    /// </summary>
    GESM,

    /// <summary>
    ///     REPO CCP GCC 14 days (EUR) - order-driven
    /// </summary>
    GESW,

    /// <summary>
    ///     REPO CCP GCC 3 months (EUR) - order-driven
    /// </summary>
    GETM,

    /// <summary>
    ///     REPO CCP GCC 6 months (EUR) - order-driven
    /// </summary>
    GEUM,

    /// <summary>
    ///     Bond indices
    /// </summary>
    GNDX,

    /// <summary>
    ///     Grain sell interventions
    /// </summary>
    GSEL,

    /// <summary>
    ///     REPO CCP 9 months (USD) - order-driven
    /// </summary>
    GUNM,

    /// <summary>
    ///     REPO CCP GCC 1 month (USD) - order-driven
    /// </summary>
    GUOM,

    /// <summary>
    ///     REPO CCP GCC 7 days (USD) - order-driven
    /// </summary>
    GUOW,

    /// <summary>
    ///     REPO CCP GCC 1 year (USD) - order-driven
    /// </summary>
    GUOY,

    /// <summary>
    ///     REPO CCP GCC 1 day (USD) - order-driven
    /// </summary>
    GURP,

    /// <summary>
    ///     REPO CCP GCC 2 months (USD) - order-driven
    /// </summary>
    GUSM,

    /// <summary>
    ///     REPO CCP GCC 14 days (USD) - order-driven
    /// </summary>
    GUSW,

    /// <summary>
    ///     REPO CCP GCC 3 months (USD) - order-driven
    /// </summary>
    GUTM,

    /// <summary>
    ///     REPO CCP GCC 6 months (USD) - order-driven
    /// </summary>
    GUUM,

    /// <summary>
    ///     REPO CCP GCC 9 months (CNY) - order-driven
    /// </summary>
    GYNM,

    /// <summary>
    ///     REPO CCP GCC 1 month (CNY) - order-driven
    /// </summary>
    GYOM,

    /// <summary>
    ///     REPO CCP GCC 7 days (CNY) - order-driven
    /// </summary>
    GYOW,

    /// <summary>
    ///     REPO CCP GCC 1 year (CNY) - order-driven
    /// </summary>
    GYOY,

    /// <summary>
    ///     REPO CCP GCC 1 day (CNY) - order-driven
    /// </summary>
    GYRP,

    /// <summary>
    ///     REPO CCP GCC 2 months (CNY) - order-driven
    /// </summary>
    GYSM,

    /// <summary>
    ///     REPO CCP GCC 14 days (CNY) - order-driven
    /// </summary>
    GYSW,

    /// <summary>
    ///     REPO CCP GCC 3 months (CNY) - order-driven
    /// </summary>
    GYTM,

    /// <summary>
    ///     REPO CCP GCC 6 months (CNY) - order-driven
    /// </summary>
    GYUM,

    /// <summary>
    ///     INAV
    /// </summary>
    INAV,

    /// <summary>
    ///     Price Fixing
    /// </summary>
    INPF,

    /// <summary>
    ///     Non System Settle's Deals - order-driven
    /// </summary>
    LICU,

    /// <summary>
    ///     Order-driven CCP deals - order-driven
    /// </summary>
    LIQB,

    /// <summary>
    ///     REPO CCP Settle's Deals - order-driven
    /// </summary>
    LIQR,

    /// <summary>
    ///     Government market
    /// </summary>
    MAIN,

    /// <summary>
    ///     Money Market IndeX
    /// </summary>
    MMIX,

    /// <summary>
    ///     MOEX Board
    /// </summary>
    MXBD,

    /// <summary>
    ///     Deposit CCP - negotiated
    /// </summary>
    NDEP,

    /// <summary>
    ///     Deposit CCP (EUR) - negotiated
    /// </summary>
    NDPE,

    /// <summary>
    ///     Deposit CCP (USD) - negotiated
    /// </summary>
    NDPU,

    /// <summary>
    ///     Deposit CCP (CNY) - negotiated
    /// </summary>
    NDPY,

    /// <summary>
    ///     Government securities:negdeals
    /// </summary>
    NEGD,

    /// <summary>
    ///     OffBoard bonds
    /// </summary>
    OBBO,

    /// <summary>
    ///     OTC deals with CCP
    /// </summary>
    OCBR,

    /// <summary>
    ///     OTC deals with CCP (USD)
    /// </summary>
    OCBU,

    /// <summary>
    ///     OTC deals with CCP (CNY)
    /// </summary>
    OCBY,

    /// <summary>
    ///     OTC deals with CCP - order-driven
    /// </summary>
    OCTR,

    /// <summary>
    ///     OTC deals with CCP (USD) - order-driven
    /// </summary>
    OCTU,

    /// <summary>
    ///     Options IQS
    /// </summary>
    OIQS,

    /// <summary>
    ///     Neg. deals: Anonymous - negotiated
    /// </summary>
    OTCB,

    /// <summary>
    ///     Neg. deals: Anonymous  (EUR)- negotiated
    /// </summary>
    OTCE,

    /// <summary>
    ///     OTC full amount
    /// </summary>
    OTCF,

    /// <summary>
    ///     OTC liquidity provider
    /// </summary>
    OTCT,

    /// <summary>
    ///     Neg. deals: Anonymous (USD)- negotiated
    /// </summary>
    OTCU,

    /// <summary>
    ///     Auction: targeted orders
    /// </summary>
    PACT,

    /// <summary>
    ///     Primary distribution auction (CNY) - negotiated
    /// </summary>
    PACY,

    /// <summary>
    ///     Primary distribution auction (EUR) - negotiated
    /// </summary>
    PAEU,

    /// <summary>
    ///     Primary distribution auction (GBP) - negotiated
    /// </summary>
    PAGB,

    /// <summary>
    ///     Primary distribution auction (USD) - negotiated
    /// </summary>
    PAUS,

    /// <summary>
    ///     REPO CCP GCC (EUR) - negotiated
    /// </summary>
    PEGC,

    /// <summary>
    ///     Primary distribution auction - negotiated
    /// </summary>
    PSAU,

    /// <summary>
    ///     Buyback - negotiated
    /// </summary>
    PSBB,

    /// <summary>
    ///     Buyback (EUR) - negotiated
    /// </summary>
    PSBE,

    /// <summary>
    ///     Buyback (USD) - negotiated
    /// </summary>
    PSBU,

    /// <summary>
    ///     Neg. deals CCP  - negotiated
    /// </summary>
    PSCC,

    /// <summary>
    ///     Neg. deals: D bonds - negotiated
    /// </summary>
    PSDB,

    /// <summary>
    ///     Neg deals: i rsk stck FRGN USD - negotiated
    /// </summary>
    PSDD,

    /// <summary>
    ///     Neg. deals: D stocks - negotiated
    /// </summary>
    PSDE,

    /// <summary>
    ///     Neg. deals: D bonds (EUR) - negotiated
    /// </summary>
    PSED,

    /// <summary>
    ///     Neg. deals: bonds (EUR) - negotiated
    /// </summary>
    PSEO,

    /// <summary>
    ///     Neg. deals: stocks, DRs - negotiated
    /// </summary>
    PSEQ,

    /// <summary>
    ///     Neg. deals: A2 stocks - negotiated
    /// </summary>
    PSES,

    /// <summary>
    ///     Neg. deals: bonds (USD) - negotiated
    /// </summary>
    PSEU,

    /// <summary>
    ///     Neg. deals: Inv. funds (USD) - negotiated
    /// </summary>
    PSFD,

    /// <summary>
    ///     Neg. deals: Inv. funds (EUR) - negotiated
    /// </summary>
    PSFE,

    /// <summary>
    ///     REPO CCP GCC - negotiated
    /// </summary>
    PSGC,

    /// <summary>
    ///     Neg. deals: bonds (GBP) - negotiated
    /// </summary>
    PSGO,

    /// <summary>
    ///     Neg. deals: inv. risk bonds (EUR) - negotiated
    /// </summary>
    PSIE,

    /// <summary>
    ///     Neg. deals: Investment share - negotiated
    /// </summary>
    PSIF,

    /// <summary>
    ///     Neg. deals: Inv. risk bonds - negotiated
    /// </summary>
    PSIR,

    /// <summary>
    ///     Neg. deals: Inv. risk bonds (USD) - negotiated
    /// </summary>
    PSIU,

    /// <summary>
    ///     Neg. deals: Inv. risk bonds (CNY) - negotiated
    /// </summary>
    PSIY,

    /// <summary>
    ///     Neg. deals: I stocks - negotiated
    /// </summary>
    PSLI,

    /// <summary>
    ///     Neg. deals: V stocks, DRs - negotiated
    /// </summary>
    PSLV,

    /// <summary>
    ///     Neg. deals: not listed bonds - negotiated
    /// </summary>
    PSNB,

    /// <summary>
    ///     Neg. deals: not listed stocks - negotiated
    /// </summary>
    PSNE,

    /// <summary>
    ///     Neg. deals: B stocks - negotiated
    /// </summary>
    PSNL,

    /// <summary>
    ///     Neg. deals: B bonds - negotiated
    /// </summary>
    PSNO,

    /// <summary>
    ///     Neg. deals: bonds - negotiated
    /// </summary>
    PSOB,

    /// <summary>
    ///     Neg. deals: A2 bonds - negotiated
    /// </summary>
    PSOS,

    /// <summary>
    ///     Neg. deals: V bonds - negotiated
    /// </summary>
    PSOV,

    /// <summary>
    ///     Neg.deals: inv.risk stocks (USD) - negotiated
    /// </summary>
    PSPD,

    /// <summary>
    ///     Neg.deals: inv.risk stocks (EUR) - negotiated
    /// </summary>
    PSPE,

    /// <summary>
    ///     Neg.deals: inv.risk stocks (HKD) - negotiated
    /// </summary>
    PSPH,

    /// <summary>
    ///     Neg. deals: inv. risk stocks - negotiated
    /// </summary>
    PSPI,

    /// <summary>
    ///     Neg.deals: inv.risk stocks (CNY) - negotiated
    /// </summary>
    PSPY,

    /// <summary>
    ///     Neg. deals for qualified investors - negotiated
    /// </summary>
    PSQI,

    /// <summary>
    ///     REPO with CCP (USD) - negotiated
    /// </summary>
    PSRD,

    /// <summary>
    ///     REPO with CCP (EUR) - negotiated
    /// </summary>
    PSRE,

    /// <summary>
    ///     REPO with CCP - negotiated
    /// </summary>
    PSRP,

    /// <summary>
    ///     REPO CCP (CNY) - negotiated
    /// </summary>
    PSRY,

    /// <summary>
    ///     Neg. deals: FRGN stocks USD - negotiated
    /// </summary>
    PSSD,

    /// <summary>
    ///     Neg. deals: Shares and DRs EUR - negotiated
    /// </summary>
    PSSE,

    /// <summary>
    ///     Neg. deals: ETC - negotiated
    /// </summary>
    PSTC,

    /// <summary>
    ///     Neg. deals: ETF (USD) - negotiated
    /// </summary>
    PSTD,

    /// <summary>
    ///     Neg. deals: ETF EUR - negotiated
    /// </summary>
    PSTE,

    /// <summary>
    ///     Neg. deals: ETF - negotiated
    /// </summary>
    PSTF,

    /// <summary>
    ///     Neg. deals: Inv. funds HKD - negotiated
    /// </summary>
    PSTH,

    /// <summary>
    ///     Neg. deals: Inv. funds CNY - negotiated
    /// </summary>
    PSTY,

    /// <summary>
    ///     Neg. deals: D bonds (USD) - negotiated
    /// </summary>
    PSUD,

    /// <summary>
    ///     Neg. deals: bonds (nonRUB) - negotiated
    /// </summary>
    PSUS,

    /// <summary>
    ///     Neg. deals: bonds (CNY) - negotiated
    /// </summary>
    PSYO,

    /// <summary>
    ///     Neg. deals CCP: D bonds - negotiated
    /// </summary>
    PTDB,

    /// <summary>
    ///     NDM w/CCP: i rsk stck FRGN USD - negotiated
    /// </summary>
    PTDD,

    /// <summary>
    ///     Neg. deals CCP: D stocks - negotiated
    /// </summary>
    PTDE,

    /// <summary>
    ///     Neg. deals CCP: Bonds (EUR) - negotiated
    /// </summary>
    PTED,

    /// <summary>
    ///     Neg. deals CCP: stocks, DRs - negotiated
    /// </summary>
    PTEQ,

    /// <summary>
    ///     Neg. deals CCP: A2 stocks - negotiated
    /// </summary>
    PTES,

    /// <summary>
    ///     Neg. deals CCP: bonds (USD) - negotiated
    /// </summary>
    PTEU,

    /// <summary>
    ///     NDM with CCP: Inv. funds (USD) - negotiated
    /// </summary>
    PTFD,

    /// <summary>
    ///     NDM with CCP: Inv. funds (EUR) - negotiated
    /// </summary>
    PTFE,

    /// <summary>
    ///     Neg. deals CCP: inv. risk bonds (EUR) - negotiated
    /// </summary>
    PTIE,

    /// <summary>
    ///     Neg. deals CCP: Investment share - negotiated
    /// </summary>
    PTIF,

    /// <summary>
    ///     Neg. deals CCP: Inv. risk bonds - negotiated
    /// </summary>
    PTIR,

    /// <summary>
    ///     Neg. deals CCP: inv. risk bonds (USD) - negotiated
    /// </summary>
    PTIU,

    /// <summary>
    ///     Neg. deals CCP: Inv. risk bonds (CNY) - negotiated
    /// </summary>
    PTIY,

    /// <summary>
    ///     Neg. deals CCP: I stocks - negotiated
    /// </summary>
    PTLI,

    /// <summary>
    ///     Neg. deals CCP: V stocks, DRs - negotiated
    /// </summary>
    PTLV,

    /// <summary>
    ///     Neg. deals CCP: not listed bonds - negotiated
    /// </summary>
    PTNB,

    /// <summary>
    ///     Neg. deals CCP: not listed stocks - negotiated
    /// </summary>
    PTNE,

    /// <summary>
    ///     Neg. deals CCP: B stocks - negotiated
    /// </summary>
    PTNL,

    /// <summary>
    ///     Neg. deals CCP: B bonds - negotiated
    /// </summary>
    PTNO,

    /// <summary>
    ///     Neg. deals CCP: bonds - negotiated
    /// </summary>
    PTOB,

    /// <summary>
    ///     Neg. deals CCP: bonds (USD) - negotiated
    /// </summary>
    PTOD,

    /// <summary>
    ///     Neg. deals CCP: bonds (EUR) - negotiated
    /// </summary>
    PTOE,

    /// <summary>
    ///     Neg. deals CCP: A2 bonds - negotiated
    /// </summary>
    PTOS,

    /// <summary>
    ///     Neg. deals CCP: V bonds - negotiated
    /// </summary>
    PTOV,

    /// <summary>
    ///     Neg. deals CCP: Bonds (CNY) - negotiated
    /// </summary>
    PTOY,

    /// <summary>
    ///     NDM CCP: inv. risk stocks (USD) - negotiated
    /// </summary>
    PTPD,

    /// <summary>
    ///     NDM CCP: inv.risk stocks (EUR) - negotiated
    /// </summary>
    PTPE,

    /// <summary>
    ///     NDM CCP: inv. risk stocks (HKD) - negotiated
    /// </summary>
    PTPH,

    /// <summary>
    ///     Neg. deals CCP: inv. risk stocks - negotiated
    /// </summary>
    PTPI,

    /// <summary>
    ///     NDM CCP: inv. risk stocks (CNY) - negotiated
    /// </summary>
    PTPY,

    /// <summary>
    ///     Neg. deals CCP for qualified investors - negotiated
    /// </summary>
    PTQI,

    /// <summary>
    ///     NDM w/CCP: FRGN stck, DRs USD - negotiated
    /// </summary>
    PTSD,

    /// <summary>
    ///     Neg.deals CCP: Shares,DRs EUR - negotiated
    /// </summary>
    PTSE,

    /// <summary>
    ///     Neg. deals CCP: ETC - negotiated
    /// </summary>
    PTTC,

    /// <summary>
    ///     Neg. deals: ETF (USD) - negotiated
    /// </summary>
    PTTD,

    /// <summary>
    ///     NDM with CCP: ETF EUR - negotiated
    /// </summary>
    PTTE,

    /// <summary>
    ///     Neg. deals CCP: ETF - negotiated
    /// </summary>
    PTTF,

    /// <summary>
    ///     NDM with CCP: Inv. funds (HKD) - negotiated
    /// </summary>
    PTTH,

    /// <summary>
    ///     NDM with CCP: Inv. funds (CNY) - negotiated
    /// </summary>
    PTTY,

    /// <summary>
    ///     Neg. deals CCP: D bonds (USD) - negotiated
    /// </summary>
    PTUD,

    /// <summary>
    ///     Neg. deals CCP: bonds (nonRUB) - negotiated
    /// </summary>
    PTUS,

    /// <summary>
    ///     REPO CCP GCC (USD) - negotiated
    /// </summary>
    PUGC,

    /// <summary>
    ///     REPO CCP GCC (CNY) - negotiated
    /// </summary>
    PYGC,

    /// <summary>
    ///     FORTS: Main session
    /// </summary>
    RFUD,

    /// <summary>
    ///     Options: Main session
    /// </summary>
    ROPD,

    /// <summary>
    ///     REPO CCP - negotiated
    /// </summary>
    RPCC,

    /// <summary>
    ///     Interdealer repo
    /// </summary>
    RPDD,

    /// <summary>
    ///     REPO (EUR) - negotiated
    /// </summary>
    RPEO,

    /// <summary>
    ///     REPO: stocks - negotiated
    /// </summary>
    RPEQ,

    /// <summary>
    ///     REPO (USD) - negotiated
    /// </summary>
    RPEU,

    /// <summary>
    ///     REPO (CNY) - negotiated
    /// </summary>
    RPEY,

    /// <summary>
    ///     REPO: bonds (GBP) - negotiated
    /// </summary>
    RPGO,

    /// <summary>
    ///     REPO: stocks - negotiated
    /// </summary>
    RPMA,

    /// <summary>
    ///     REPO-M - negotiated
    /// </summary>
    RPMO,

    /// <summary>
    ///     REPO: for qualified investors - negotiated
    /// </summary>
    RPQI,

    /// <summary>
    ///     REPO: stocks (USD) - negotiated
    /// </summary>
    RPUA,

    /// <summary>
    ///     REPO: bonds (USD) - negotiated
    /// </summary>
    RPUO,

    /// <summary>
    ///     REPO: for qualified investors (USD) - negotiated
    /// </summary>
    RPUQ,

    /// <summary>
    ///     RTS indices
    /// </summary>
    RTSI,

    /// <summary>
    ///     Standard: Evening session - negotiated
    /// </summary>
    SDAD,

    /// <summary>
    ///     Large Volume Trades - order-driven
    /// </summary>
    SDBP,

    /// <summary>
    ///     SDFI Indices
    /// </summary>
    SDII,

    /// <summary>
    ///     Standard: Evening session - order-driven
    /// </summary>
    SDMR,

    /// <summary>
    ///     Standard: REPO, Evening session - negotiated
    /// </summary>
    SDRP,

    /// <summary>
    ///     T+: stocks odd lot trading - order-driven
    /// </summary>
    SMAL,

    /// <summary>
    ///     Shares indices
    /// </summary>
    SNDX,

    /// <summary>
    ///     Reporting OTC trades (06-67/pz-n)
    /// </summary>
    SOTC,

    /// <summary>
    ///     Settlement - order-driven
    /// </summary>
    SPEC,

    /// <summary>
    ///     Delivery for FC (shares)
    /// </summary>
    SPEQ,

    /// <summary>
    ///     Delivery OFZ
    /// </summary>
    SPOB,

    /// <summary>
    ///     Standard: Main session - negotiated
    /// </summary>
    STAD,

    /// <summary>
    ///     Standard: Main session - order-driven
    /// </summary>
    STMR,

    /// <summary>
    ///     Standard: REPO, Main session - negotiated
    /// </summary>
    STRP,

    /// <summary>
    ///     Agro: Sugar
    /// </summary>
    SUGR,

    /// <summary>
    ///     Deposit CCP - order-driven
    /// </summary>
    TDEP,

    /// <summary>
    ///     Deposit CCP (EUR) - order-driven
    /// </summary>
    TDPE,

    /// <summary>
    ///     Deposit CCP (USD) - order-driven
    /// </summary>
    TDPU,

    /// <summary>
    ///     Deposit CCP (CNY) - order-driven
    /// </summary>
    TDPY,

    /// <summary>
    ///     T+: FRGN stocks, DRs USD - order-driven
    /// </summary>
    TQBD,

    /// <summary>
    ///     T+: Shares and DRs EUR - order-driven
    /// </summary>
    TQBE,

    /// <summary>
    ///     T+: stocks, DRs - order-driven
    /// </summary>
    TQBR,

    /// <summary>
    ///     T+: A2 stocks - order-driven
    /// </summary>
    TQBS,

    /// <summary>
    ///     T+: Bonds - order-driven
    /// </summary>
    TQCB,

    /// <summary>
    ///     Dark pool: bonds - order-driven
    /// </summary>
    TQDB,

    /// <summary>
    ///     T+: inv. risk stocks FRGN USD - order-driven
    /// </summary>
    TQDD,

    /// <summary>
    ///     T+: D stocks - order-driven
    /// </summary>
    TQDE,

    /// <summary>
    ///     Dark pool: stocks - order-driven
    /// </summary>
    TQDP,

    /// <summary>
    ///     Dark pool: bonds USD - order-driven
    /// </summary>
    TQDU,

    /// <summary>
    ///     T+: D bonds (EUR) - order-driven
    /// </summary>
    TQED,

    /// <summary>
    ///     T+: Inv. funds (USD) - order-driven
    /// </summary>
    TQFD,

    /// <summary>
    ///     T+: Inv. funds (EUR) - order-driven
    /// </summary>
    TQFE,

    /// <summary>
    ///     T+: Bonds inv. risk (EUR) - order-driven
    /// </summary>
    TQIE,

    /// <summary>
    ///     T+: Investment shares - order-driven
    /// </summary>
    TQIF,

    /// <summary>
    ///     T+ Bonds inv. Risk - order-driven
    /// </summary>
    TQIR,

    /// <summary>
    ///     T+: Bonds inv. risk (USD) - order-driven
    /// </summary>
    TQIU,

    /// <summary>
    ///     T+: Bonds inv. risk (CNY) - order-driven
    /// </summary>
    TQIY,

    /// <summary>
    ///     T+: I stocks - order-driven
    /// </summary>
    TQLI,

    /// <summary>
    ///     T+: V stocks, DRs - order-driven
    /// </summary>
    TQLV,

    /// <summary>
    ///     T+: not listed bonds - order-driven
    /// </summary>
    TQNB,

    /// <summary>
    ///     T+: not listed stocks - order-driven
    /// </summary>
    TQNE,

    /// <summary>
    ///     T+: B stocks - order-driven
    /// </summary>
    TQNL,

    /// <summary>
    ///     T+: B bonds - order-driven
    /// </summary>
    TQNO,

    /// <summary>
    ///     T+: Government bonds - order-driven
    /// </summary>
    TQOB,

    /// <summary>
    ///     T+: bonds (USD) - order-driven
    /// </summary>
    TQOD,

    /// <summary>
    ///     T+: Bonds (EUR) - order-driven
    /// </summary>
    TQOE,

    /// <summary>
    ///     T+: A2 bonds - order-driven
    /// </summary>
    TQOS,

    /// <summary>
    ///     T+: V bonds - order-driven
    /// </summary>
    TQOV,

    /// <summary>
    ///     T+ Bonds CNY
    /// </summary>
    TQOY,

    /// <summary>
    ///     T+: stocks inv. Risk (USD) - order-driven
    /// </summary>
    TQPD,

    /// <summary>
    ///     T+: stocks inv. Risk (EUR) - order-driven
    /// </summary>
    TQPE,

    /// <summary>
    ///     T+: stocks inv. Risk (HKD) - order-driven
    /// </summary>
    TQPH,

    /// <summary>
    ///     T+: Stocks inv. Risk - order-driven
    /// </summary>
    TQPI,

    /// <summary>
    ///     T+: stocks inv. Risk (CNY) - order-driven
    /// </summary>
    TQPY,

    /// <summary>
    ///     T+: for qualified investors (USD) - order-driven
    /// </summary>
    TQQD,

    /// <summary>
    ///     T+: for qualified investors - order-driven
    /// </summary>
    TQQI,

    /// <summary>
    ///     T+: D bonds - order-driven
    /// </summary>
    TQRD,

    /// <summary>
    ///     T+: ETC - order-driven
    /// </summary>
    TQTC,

    /// <summary>
    ///     T+: ETF (USD) - order-driven
    /// </summary>
    TQTD,

    /// <summary>
    ///     T+: ETF (EUR) - order-driven
    /// </summary>
    TQTE,

    /// <summary>
    ///     T+: ETF - order-driven
    /// </summary>
    TQTF,

    /// <summary>
    ///     T+: Inv. funds (HKD) - order-driven
    /// </summary>
    TQTH,

    /// <summary>
    ///     T+: Inv. funds (CNY) - order-driven
    /// </summary>
    TQTY,

    /// <summary>
    ///     T+: D bonds (USD) - order-driven
    /// </summary>
    TQUD,

    /// <summary>
    ///     T+: not listed bonds (nonRUB) - order-driven
    /// </summary>
    TQUS,

    /// <summary>
    ///     Negotiated WAP Deals - negotiated
    /// </summary>
    WAPN,

    /// <summary>
    ///     System WAP Deals - order-driven
    /// </summary>
    WAPS
}