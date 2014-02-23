// -----------------------------------------------------------------------
// <copyright file="enums.cs" company="Microsoft">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

using System.ComponentModel;

namespace Framework.Common
{
    public enum Days
    {
        [Description("First day of week")]
        Monday,
        [Description("Second day of week")]
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday,
    }
}
