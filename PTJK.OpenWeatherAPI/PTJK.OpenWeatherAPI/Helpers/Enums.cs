using System;
using System.Collections.Generic;
using System.Text;

namespace PTJK.OpenWeatherAPI.Helpers
{
    public enum MetricSystem
    {
        Internal, Metric, Imperial
    }

    public enum Language
    {
        /// <summary>
        /// Afrikaans
        /// </summary>
        AF,
        /// <summary>
        /// Albanian
        /// </summary>
        AL,
        /// <summary>
        /// Arabic
        /// </summary>
        AR,
        /// <summary>
        /// Azerbaijani
        /// </summary>
        AZ,
        /// <summary>
        /// Bulgarian
        /// </summary>
        BG,
        /// <summary>
        /// Catalan
        /// </summary>
        CA,
        /// <summary>
        /// Czech
        /// </summary>
        CZ,
        /// <summary>
        /// Danish
        /// </summary>
        DA,
        /// <summary>
        /// German
        /// </summary>
        DE,
        /// <summary>
        /// Greek
        /// </summary>
        EL,
        /// <summary>
        /// English
        /// </summary>
        EN,
        /// <summary>
        /// Basque
        /// </summary>
        EU,
        /// <summary>
        /// Persian (Farsi)
        /// </summary>
        FA,
        /// <summary>
        /// Finnish
        /// </summary>
        FI,
        /// <summary>
        /// French
        /// </summary>
        FR,
        /// <summary>
        /// Galician
        /// </summary>
        GL,
        /// <summary>
        /// Hebrew
        /// </summary>
        HE,
        /// <summary>
        /// Hindi
        /// </summary>
        HI,
        /// <summary>
        /// Croatian
        /// </summary>
        HR,
        /// <summary>
        /// Hungarian
        /// </summary>
        HU,
        /// <summary>
        /// Indonesian
        /// </summary>
        ID,
        /// <summary>
        /// Italian
        /// </summary>
        IT,
        /// <summary>
        /// Japanese
        /// </summary>
        JA,
        /// <summary>
        /// Korean
        /// </summary>
        KR,
        /// <summary>
        /// Latvian
        /// </summary>
        LA,
        /// <summary>
        /// Lithuanian
        /// </summary>
        LT,
        /// <summary>
        /// Macedonian
        /// </summary>
        MK,
        /// <summary>
        /// Norwegian
        /// </summary>
        NO,
        /// <summary>
        /// Dutch
        /// </summary>
        NL,
        /// <summary>
        /// Polish
        /// </summary>
        PL,
        /// <summary>
        /// Portuguese
        /// </summary>
        PT,
        /// <summary>
        /// Português Brasil
        /// </summary>
        PT_BR,
        /// <summary>
        /// Romanian
        /// </summary>
        RO,
        /// <summary>
        /// Russian
        /// </summary>
        RU,
        /// <summary>
        ///  Swedish
        /// </summary>
        SV,
        /// <summary>
        /// Slovak
        /// </summary>
        SK,
        /// <summary>
        /// Slovenian
        /// </summary>
        SL,
        /// <summary>
        ///  Spanish
        /// </summary>
        ES,
        /// <summary>
        /// Serbian
        /// </summary>
        SR,
        /// <summary>
        /// Thai
        /// </summary>
        TH,
        /// <summary>
        /// Turkish
        /// </summary>
        TR,
        /// <summary>
        ///  Ukrainian
        /// </summary>
        UA,
        /// <summary>
        /// Vietnamese
        /// </summary>
        VI,
        /// <summary>
        /// Chinese Simplified
        /// </summary>
        ZH_CN,
        /// <summary>
        /// Chinese Traditional
        /// </summary>
        ZH_TW,
        /// <summary>
        /// Zulu
        /// </summary>
        ZU
    }

    public enum Accuracy { Like,Accurate }

    public enum ForecastAmount
    {
        Hourly,
        Daily,
        Climate
    }
}
