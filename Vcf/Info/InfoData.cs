﻿using VariantAnnotation.Interface.Positions;

namespace Vcf.Info
{
    public sealed class InfoData : IInfoData
    {
        public int[] CiEnd { get; }
        public int[] CiPos { get; }
        public int? End { get; }
        public int? JointSomaticNormalQuality { get; }
        public int? RefRepeatCount { get; }
        public string RepeatUnit { get; }
        public double? StrandBias { get; }
        public int? SvLength { get; }
        public string SvType { get; }

        public InfoData(int[] ciEnd, int[] ciPos, int? end, int? jointSomaticNormalQuality, int? refRepeatCount,
            string repeatUnit, double? strandBias, int? svLength, string svType)
        {
            CiEnd                     = ciEnd;
            CiPos                     = ciPos;
            End                       = end;
            JointSomaticNormalQuality = jointSomaticNormalQuality;
            RefRepeatCount            = refRepeatCount;
            RepeatUnit                = repeatUnit;
            StrandBias                = strandBias;
            SvLength                  = svLength;
            SvType                    = svType;
        }
    }
}