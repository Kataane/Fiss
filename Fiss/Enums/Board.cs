namespace Fiss.Enums;

/// <summary>
/// Режимы торгов рынка
/// </summary>
public enum Board
{

    /// <summary>
    /// Депозиты с ЦК аукцион закл. (для участников рынка депозитов с ЦК)
    /// </summary>
    ADEP,

    /// <summary>
    /// Выкуп: Аукцион
    /// </summary>
    AUBB,

    /// <summary>
    /// Аукцион
    /// </summary>
    AUCT,

    /// <summary>
    /// НГЦБ-Перевод денег
    /// </summary>
    CASF,

    /// <summary>
    /// Крупные пакеты - Акции
    /// </summary>
    TQDP,

    /// <summary>
    /// РЕПО с ЦК 1 мес. (расч. в USD)
    /// </summary>
    EQMD,

    /// <summary>
    /// РЕПО с ЦК 1 мес. (расч. в EUR)
    /// </summary>
    EQME,

    /// <summary>
    /// РЕПО с ЦК 1 мес.
    /// </summary>
    EQMP,

    /// <summary>
    /// РЕПО с ЦК 1 день (расч. в USD)
    /// </summary>
    EQRD,

    /// <summary>
    /// РЕПО с ЦК 1 день (расч. в EUR)
    /// </summary>
    EQRE,

    /// <summary>
    /// РЕПО с ЦК 1 день
    /// </summary>
    EQRP,

    /// <summary>
    /// Т0 ETC
    /// </summary>
    EQTC,

    /// <summary>
    /// Т0 ETF (расч. в USD)
    /// </summary>
    EQTD,

    /// <summary>
    /// РЕПО с ЦК 3 мес. (расч. в EUR)
    /// </summary>
    EQTE,

    /// <summary>
    /// РЕПО с ЦК 3 мес.
    /// </summary>
    EQTP,

    /// <summary>
    /// Т0 ETF (расч. в EUR)
    /// </summary>
    EQTU,

    /// <summary>
    /// РЕПО с ЦК 7 дн. (расч. в USD)
    /// </summary>
    EQWD,

    /// <summary>
    /// РЕПО с ЦК 7 дн. (расч. в EUR)
    /// </summary>
    EQWE,

    /// <summary>
    /// РЕПО с ЦК 7 дн.
    /// </summary>
    EQWP,

    /// <summary>
    /// РЕПО с ЦК 3 мес. (расч. в USD)
    /// </summary>
    ETQD,

    /// <summary>
    /// РЕПО с ЦБ РФ: Аукцион РЕПО
    /// </summary>
    FBCB,

    /// <summary>
    /// EUR РЕПО с ЦБ РФ: Аукцион РЕПО
    /// </summary>
    FBCE,

    /// <summary>
    /// USD РЕПО с ЦБ РФ: Аукцион РЕПО
    /// </summary>
    FBCU,

    /// <summary>
    /// РЕПО с ЦБ РФ: фикс.ставка
    /// </summary>
    FBFX,

    /// <summary>
    /// Аукцион с ЦК с КСУ 1 месяц
    /// </summary>
    FKOM,

    /// <summary>
    /// Аукцион с ЦК с КСУ 7 дней
    /// </summary>
    FKOW,

    /// <summary>
    /// Аукцион с ЦК с КСУ 1 год
    /// </summary>
    FKOY,

    /// <summary>
    /// Аукцион с ЦК с КСУ 1 день
    /// </summary>
    FKRP,

    /// <summary>
    /// Аукцион с ЦК с КСУ 2 месяца
    /// </summary>
    FKSM,

    /// <summary>
    /// Аукцион с ЦК с КСУ 14 дней
    /// </summary>
    FKSW,

    /// <summary>
    /// Аукцион с ЦК с КСУ 3 месяца
    /// </summary>
    FKTM,

    /// <summary>
    /// Аукцион с ЦК с КСУ 6 месяцев
    /// </summary>
    FKUM,

    /// <summary>
    /// РЕПО с ЦК с КСУ 9 месяцев
    /// </summary>
    GCNM,

    /// <summary>
    /// РЕПО с ЦК с КСУ 1 месяц
    /// </summary>
    GCOM,

    /// <summary>
    /// РЕПО с ЦК с КСУ 7 дн.
    /// </summary>
    GCOW,

    /// <summary>
    /// РЕПО С ЦК с КСУ 1 год
    /// </summary>
    GCOY,

    /// <summary>
    /// РЕПО с ЦК с КСУ 1 день
    /// </summary>
    GCRP,

    /// <summary>
    /// РЕПО с ЦК с КСУ 2 месяца
    /// </summary>
    GCSM,

    /// <summary>
    /// РЕПО с ЦК с КСУ 14 дн.
    /// </summary>
    GCSW,

    /// <summary>
    /// РЕПО с ЦК с КСУ 3 месяца
    /// </summary>
    GCTM,

    /// <summary>
    /// Автоматические переводы КСУ
    /// </summary>
    GCTR,

    /// <summary>
    /// РЕПО с ЦК с КСУ 6 месяцев
    /// </summary>
    GCUM,

    /// <summary>
    /// РЕПО с ЦК с КСУ 9 мес. (EUR)
    /// </summary>
    GENM,

    /// <summary>
    /// РЕПО с ЦК с КСУ 1 мес. (EUR)
    /// </summary>
    GEOM,

    /// <summary>
    /// РЕПО с ЦК с КСУ 7 дн. (EUR)
    /// </summary>
    GEOW,

    /// <summary>
    /// РЕПО с ЦК с КСУ 1 год (EUR) 
    /// </summary>
    GEOY,

    /// <summary>
    /// РЕПО с ЦК с КСУ 1 день (EUR)
    /// </summary>
    GERP,

    /// <summary>
    /// РЕПО с ЦК с КСУ 2 мес. (EUR)
    /// </summary>
    GESM,

    /// <summary>
    /// РЕПО с ЦК с КСУ 14 дн. (EUR)
    /// </summary>
    GESW,

    /// <summary>
    /// РЕПО с ЦК с КСУ 3 мес. (EUR)
    /// </summary>
    GETM,

    /// <summary>
    /// РЕПО с ЦК с КСУ 6 мес. (EUR)
    /// </summary>
    GEUM,

    /// <summary>
    /// РЕПО с ЦК с КСУ 9 мес. (USD)
    /// </summary>
    GUNM,

    /// <summary>
    /// РЕПО с ЦК с КСУ 1 месяц (USD)
    /// </summary>
    GUOM,

    /// <summary>
    /// РЕПО с ЦК с КСУ 7 дн. (USD)
    /// </summary>
    GUOW,

    /// <summary>
    /// РЕПО с ЦК с КСУ 1 год (USD)
    /// </summary>
    GUOY,

    /// <summary>
    /// РЕПО с ЦК с КСУ 1 день (USD)
    /// </summary>
    GURP,

    /// <summary>
    /// РЕПО с ЦК с КСУ 2 месяца (USD)
    /// </summary>
    GUSM,

    /// <summary>
    /// РЕПО с ЦК с КСУ 14 дн. (USD)
    /// </summary>
    GUSW,

    /// <summary>
    /// РЕПО с ЦК с КСУ 3 месяца (USD)
    /// </summary>
    GUTM,

    /// <summary>
    /// РЕПО с ЦК с КСУ 6 месяцев (USD)
    /// </summary>
    GUUM,

    /// <summary>
    /// Индексы
    /// </summary>
    INDT,

    /// <summary>
    /// ИРК2-РПС
    /// </summary>
    IRK2,

    /// <summary>
    /// Урегулирование с ЦК орг. торги
    /// </summary>
    LIQB,

    /// <summary>
    /// Урегулирование с ЦК внебирж.
    /// </summary>
    LIQO,

    /// <summary>
    /// РЕПО с ЦК: Урегулирование
    /// </summary>
    LIQR,

    /// <summary>
    /// Исполнение обяз. Т+: РПС
    /// </summary>
    NADM,

    /// <summary>
    /// Внебиржевые сделки с ЦК (EUR)
    /// </summary>
    OCPE,

    /// <summary>
    /// Внебиржевые сделки с ЦК
    /// </summary>
    OCPR,

    /// <summary>
    /// Внебиржевые сделки с ЦК (USD)
    /// </summary>
    OCPU,

    /// <summary>
    /// Анонимный РПС
    /// </summary>
    OTCB,

    /// <summary>
    /// Анонимный РПС (EUR)
    /// </summary>
    OTCE,

    /// <summary>
    /// Анонимный РПС (USD)
    /// </summary>
    OTCU,

    /// <summary>
    /// Аукцион: адресные заявки
    /// </summary>
    PACT,

    /// <summary>
    /// Размещение:Адресные заявки CNY
    /// </summary>
    PACY,

    /// <summary>
    /// Размещение:Адресные заявки EUR
    /// </summary>
    PAEU,

    /// <summary>
    /// Размещение:Адресные заявки GBP
    /// </summary>
    PAGB,

    /// <summary>
    /// Размещение:Адресные заявки USD
    /// </summary>
    PAUS,

    /// <summary>
    /// РЕПО с ЦК с КСУ адресн. (EUR)
    /// </summary>
    PEGC,

    /// <summary>
    /// Размещение: Адресные заявки
    /// </summary>
    PSAU,

    /// <summary>
    /// Выкуп: Адресные заявки
    /// </summary>
    PSBB,

    /// <summary>
    /// Выкуп: Адресные заявки EUR
    /// </summary>
    PSBE,

    /// <summary>
    /// Выкуп: Адресные заявки USD
    /// </summary>
    PSBU,

    /// <summary>
    /// Облигации Д - РПС
    /// </summary>
    PSDB,

    /// <summary>
    /// Облигации Д – РПС (расч.в EUR)
    /// </summary>
    PSED,

    /// <summary>
    /// РПС:Облигации (расч.в EUR)
    /// </summary>
    PSEO,

    /// <summary>
    /// РПС : Акции
    /// </summary>
    PSEQ,

    /// <summary>
    /// РПС:Облигации (расч.в USD)
    /// </summary>
    PSEU,

    /// <summary>
    /// РЕПО с ЦК с КСУ адресное
    /// </summary>
    PSGC,

    /// <summary>
    /// РПС:Облигации (расч.в GBP)
    /// </summary>
    PSGO,

    /// <summary>
    /// РПС Облигации ПИР (расч.в EUR)
    /// </summary>
    PSIE,

    /// <summary>
    /// РПС: Паи
    /// </summary>
    PSIF,

    /// <summary>
    /// РПС Облигации ПИР 
    /// </summary>
    PSIR,

    /// <summary>
    /// РПС Облигации ПИР (расч.в USD)
    /// </summary>
    PSIU,

    /// <summary>
    /// РПС Облигации ПИР (расч.в CNY)
    /// </summary>
    PSIY,

    /// <summary>
    /// РПС : Облигации
    /// </summary>
    PSOB,

    /// <summary>
    /// РПС Акции ПИР
    /// </summary>
    PSPI,

    /// <summary>
    /// РЕПО с ЦК адр. (расч. в USD)
    /// </summary>
    PSRD,

    /// <summary>
    /// РЕПО с ЦК адр.(расч. в EUR)
    /// </summary>
    PSRE,

    /// <summary>
    /// РЕПО с ЦК адресное
    /// </summary>
    PSRP,

    /// <summary>
    /// РЕПО с ЦК адр. (расч. в CNY)
    /// </summary>
    PSRY,

    /// <summary>
    /// РПС: Ин.Акции (USD)
    /// </summary>
    PSSD,

    /// <summary>
    /// РПС: Акции и ДР (расч. в EUR)
    /// </summary>
    PSSE,

    /// <summary>
    /// РПС: ETC
    /// </summary>
    PSTC,

    /// <summary>
    /// РПС: ETF (расч. в USD)
    /// </summary>
    PSTD,

    /// <summary>
    /// РПС: ETF (расч. в EUR)
    /// </summary>
    PSTE,

    /// <summary>
    /// РПС: ETF
    /// </summary>
    PSTF,

    /// <summary>
    /// Облигации Д - РПС (расч.в USD)
    /// </summary>
    PSUD,

    /// <summary>
    /// РПС:Облигации (расч.в CNY)
    /// </summary>
    PSYO,

    /// <summary>
    /// РПС с ЦК: Д Облигации
    /// </summary>
    PTDB,

    /// <summary>
    /// РПС с ЦК: Д Облигации (расч.EUR)
    /// </summary>
    PTED,

    /// <summary>
    /// РПС с ЦК: Акции и ДР
    /// </summary>
    PTEQ,

    /// <summary>
    /// РПС с ЦК Облигации ПИР (расч.в EUR)
    /// </summary>
    PTIE,

    /// <summary>
    /// РПС с ЦК: Паи
    /// </summary>
    PTIF,

    /// <summary>
    /// РПС с ЦК Облигации ПИР 
    /// </summary>
    PTIR,

    /// <summary>
    /// РПС с ЦК Облигации ПИР (расч.в USD)
    /// </summary>
    PTIU,

    /// <summary>
    /// РПС с ЦК Облигации ПИР (расч.в CNY)
    /// </summary>
    PTIY,

    /// <summary>
    /// РПС с ЦК: Облигации
    /// </summary>
    PTOB,

    /// <summary>
    /// РПС с ЦК: Облигации (расч. в USD)
    /// </summary>
    PTOD,

    /// <summary>
    /// РПС с ЦК: Облигации (расч.EUR)
    /// </summary>
    PTOE,

    /// <summary>
    /// РПС с ЦК Акции ПИР 
    /// </summary>
    PTPI,

    /// <summary>
    /// РПС с ЦК: Ин.Акции и ДР (USD)
    /// </summary>
    PTSD,

    /// <summary>
    /// РПС с ЦК: Акции и ДР (расч. в EUR)
    /// </summary>
    PTSE,

    /// <summary>
    /// РПС с ЦК:ETC
    /// </summary>
    PTTC,

    /// <summary>
    /// РПС с ЦК: ETF (расч. в USD)
    /// </summary>
    PTTD,

    /// <summary>
    /// РПС с ЦК: ETF (расч. в EUR)
    /// </summary>
    PTTE,

    /// <summary>
    /// РПС с ЦК: ETF
    /// </summary>
    PTTF,

    /// <summary>
    /// РПС с ЦК: Д Облигации (расч.USD)
    /// </summary>
    PTUD,

    /// <summary>
    /// РЕПО с ЦК с КСУ адресное (расч. в USD)
    /// </summary>
    PUGC,

    /// <summary>
    /// Возврат выплат
    /// </summary>
    RFND,

    /// <summary>
    /// Возврат выплат (EUR)    
    /// </summary>
    RFNE,

    /// <summary>
    /// Возврат выплат (USD)
    /// </summary>
    RFNU,

    /// <summary>
    /// РЕПО в ин. валюте: EUR
    /// </summary>
    RPEO,

    /// <summary>
    /// РЕПО в ин. валюте: USD
    /// </summary>
    RPEU,

    /// <summary>
    /// РЕПО в ин. валюте: CNY 
    /// </summary>
    RPEY,

    /// <summary>
    /// РЕПО внебиржевое: фикс.ставка
    /// </summary>
    RPFG,

    /// <summary>
    /// РЕПО c облигациями(расч.в GBP)
    /// </summary>
    RPGO,

    /// <summary>
    /// РЕПО-M: Облигации
    /// </summary>
    RPMO,

    /// <summary>
    /// РЕПО внебиржевое: аукцион
    /// </summary>
    RPNG,

    /// <summary>
    /// Исполнение обяз. Т+: СВОП
    /// </summary>
    SADM,

    /// <summary>
    /// Т+ Неполные лоты
    /// </summary>
    SMAL,

    /// <summary>
    /// Поставка по СК (акции)
    /// </summary>
    SPEQ,

    /// <summary>
    /// Поставка по СК (облигации)
    /// </summary>
    SPOB,

    /// <summary>
    /// Исполнение обяз. Т+: РЕПО
    /// </summary>
    TADM,

    /// <summary>
    /// Т+ Ин.Акции и ДР (USD)
    /// </summary>
    TQBD,

    /// <summary>
    /// Т+ Акции и ДР (расч. в EUR)
    /// </summary>
    TQBE,

    /// <summary>
    /// Т+ Акции и ДР
    /// </summary>
    TQBR,

    /// <summary>
    /// Т+ Облигации
    /// </summary>
    TQCB,

    /// <summary>
    /// Крупные пакеты - Облигации
    /// </summary>
    TQDB,

    /// <summary>
    /// Крупные пакеты - Облигации (USD)
    /// </summary>
    TQDU,

    /// <summary>
    /// Т+ Облигации Д (расч. в EUR)
    /// </summary>
    TQED,

    /// <summary>
    /// Т+ Облигации ПИР (расч.в EUR)
    /// </summary>
    TQIE,

    /// <summary>
    /// Т+ Паи
    /// </summary>
    TQIF,

    /// <summary>
    /// Т+ Облигации ПИР 
    /// </summary>
    TQIR,

    /// <summary>
    /// Т+ Облигации ПИР (расч.в USD)
    /// </summary>
    TQIU,

    /// <summary>
    /// Т+ Облигации ПИР (расч.в CNY)
    /// </summary>
    TQIY,

    /// <summary>
    /// Т+ Гособлигации
    /// </summary>
    TQOB,

    /// <summary>
    /// Т+ Облигации (расч.в USD)
    /// </summary>
    TQOD,

    /// <summary>
    /// Т+ Облигации (расч.в EUR)
    /// </summary>
    TQOE,

    /// <summary>
    /// Т+ Облигации (расч.в CNY)
    /// </summary>
    TQOY,

    /// <summary>
    /// Т+ Акции ПИР
    /// </summary>
    TQPI,

    /// <summary>
    /// Т+ Облигации Д
    /// </summary>
    TQRD,

    /// <summary>
    /// Т+ ETC
    /// </summary>
    TQTC,

    /// <summary>
    /// Т+ ETF (расч. в USD)
    /// </summary>
    TQTD,

    /// <summary>
    /// Т+ ETF (расч. в EUR)
    /// </summary>
    TQTE,

    /// <summary>
    /// Т+ ETF
    /// </summary>
    TQTF,

    /// <summary>
    /// Т+ Облигации Д (расч. в USD)
    /// </summary>
    TQUD,

    /// <summary>
    /// Переводы
    /// </summary>
    TRAN,

    /// <summary>
    /// РЕПО с ЦБ РФ: Аукцион плав. ставки
    /// </summary>
    FFCB,

    /// <summary>
    /// Т+ Ин.Акции и ДР
    /// </summary>
    FQBR,

    /// <summary>
    /// РПС с ЦК: Ин.Акции и ДР
    /// </summary>
    FTEQ,

    /// <summary>
    /// РПС: Ин.Акции
    /// </summary>
    FSEQ,

    /// <summary>
    /// Т+ Ин.Акции ПИР
    /// </summary>
    FQDE,

    /// <summary>
    /// РПС с ЦК: Ин.Акции ПИР
    /// </summary>
    FTDE,

    /// <summary>
    /// Ин.Акции ПИР - РПС
    /// </summary>
    FSDE,

    /// <summary>
    /// Т+ ПАИ (расч. в USD)
    /// </summary>
    TQFD,

    /// <summary>
    /// РПС с ЦК: Паи (расч. в USD)
    /// </summary>
    PTFD,

    /// <summary>
    /// РПС: ПАИ (расч. в USD)
    /// </summary>
    PSFD,

    /// <summary>
    /// Т+ ПАИ (расч. в EUR)
    /// </summary>
    TQFE,

    /// <summary>
    /// РПС с ЦК: Паи (расч. в EUR)
    /// </summary>
    PTFE,

    /// <summary>
    /// РПС: ПАИ (расч. в EUR)
    /// </summary>
    PSFE,

    /// <summary>
    /// Т+ Акции ПИР (расч. в USD)
    /// </summary>
    TQPD,

    /// <summary>
    /// РПС Акции ПИР (расч. в USD)
    /// </summary>
    PSPD,

    /// <summary>
    /// РПС с ЦК Акции ПИР (USD)
    /// </summary>
    PTPD,

    /// <summary>
    /// Т+ Акции ПИР (расч. в EUR)
    /// </summary>
    TQPE,

    /// <summary>
    /// РПС Акции ПИР (расч. в EUR)
    /// </summary>
    PSPE,

    /// <summary>
    /// РПС с ЦК Акции ПИР (EUR)
    /// </summary>
    PTPE,

    /// <summary>
    /// Т+ Ин.Акции ПИР (USD)
    /// </summary>
    TQDD,

    /// <summary>
    /// РПС с ЦК: Ин.Акции ПИР (USD)
    /// </summary>
    PTDD,

    /// <summary>
    /// Ин.Акции ПИР – РПС (USD)
    /// </summary>
    PSDD
}
