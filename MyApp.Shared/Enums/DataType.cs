using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tapper;

namespace SmacoDevs.MyShared.Enums
{
    [TranspilationSource]
    public enum DataType
    {
        PositiveNegative = 1,
        Numeric = 2,
        Text = 3,
        Percentage = 4,
        MultiSelect = 5,
        Date = 6
    }

    [TranspilationSource]
    public enum MedicalNoteDataType
    {
        Text = DataType.Text,
        MultiSelect = DataType.MultiSelect,
        Date = DataType.Date
    }
}
