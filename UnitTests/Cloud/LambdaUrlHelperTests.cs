﻿using System;
using Cloud;
using Cloud.Utilities;
using Genome;
using IO;
using ReferenceSequence;
using VariantAnnotation.SA;
using Xunit;

namespace UnitTests.Cloud
{
    public sealed class LambdaUrlHelperTests
    {
        [Fact]
        public void GetDataUrlBase_AsExpected()
        {
            Assert.Equal($"http://somewhere.on.the.earth/ab0cf104f39708eabd07b8cb67e149ba-Cache/{CacheConstants.DataVersion}/", LambdaUrlHelper.GetCacheFolder("http://somewhere.on.the.earth/"));
            Assert.Equal($"http://somewhere.on.the.earth/d95867deadfe690e40f42068d6b59df8-References/{ReferenceSequenceCommon.HeaderVersion}/Homo_sapiens.", LambdaUrlHelper.GetRefPrefix("http://somewhere.on.the.earth/"));
        }

        [Fact]
        public void GetS3RefLocation_AsExpected()
        {
            Assert.Equal(LambdaUrlHelper.GetRefPrefix("whatever") + "GRCh37" + LambdaUrlHelper.RefSuffix, LambdaUrlHelper.GetRefUrl(GenomeAssembly.GRCh37, "whatever"));
        }
        
        [Fact]
        public void GetS3_SaManifest_Location_AsExpected()
        {
            Environment.SetEnvironmentVariable("NirvanaDataUrlBase", "http://nirvana-annotations.s3.us-west-2.amazonaws.com/");
            var saManifestUrl = LambdaUtilities.GetManifestUrl("latest", GenomeAssembly.GRCh38, SaCommon.SchemaVersion);
            HttpUtilities.ValidateUrl(saManifestUrl);
        }
    }
}
