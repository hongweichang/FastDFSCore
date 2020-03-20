﻿using System;
using System.IO;
using Xunit;

namespace FastDFSCore.Tests
{
    public class FDFSOptionHelperTest
    {

        [Fact]
        public void GetFDFSOption_ToXml_Test()
        {
            var option = FDFSOptionHelper.GetFDFSOption("FDFSOption.xml");
            Assert.NotNull(option);

            Assert.Single(option.Trackers);
            Assert.Equal("utf-8", option.Charset);
            Assert.Equal(5, option.ConnectionTimeout);
            Assert.Equal(3200, option.ConnectionLifeTime);
            Assert.Equal(10, option.ScanTimeoutConnectionInterval);
            Assert.Equal(5, option.TrackerMaxConnection);
            Assert.Equal(20, option.StorageMaxConnection);
            Assert.Equal("Name1", option.LoggerName);
            Assert.Equal(30, option.TcpSetting.QuietPeriodMilliSeconds);
            Assert.Equal(1, option.TcpSetting.CloseTimeoutSeconds);
            Assert.Equal(16777216, option.TcpSetting.WriteBufferHighWaterMark);
            Assert.Equal(8388608, option.TcpSetting.WriteBufferLowWaterMark);
            Assert.Equal(1048576, option.TcpSetting.SoRcvbuf);
            Assert.Equal(1048576, option.TcpSetting.SoSndbuf);
            Assert.True(option.TcpSetting.TcpNodelay);
            Assert.False(option.TcpSetting.SoReuseaddr);
            Assert.True(option.TcpSetting.EnableReConnect);
            Assert.Equal(3, option.TcpSetting.ReConnectDelaySeconds);
            Assert.Equal(1001, option.TcpSetting.ReConnectIntervalMilliSeconds);
            Assert.Equal(10, option.TcpSetting.ReConnectMaxCount);


            var xml = FDFSOptionHelper.ToXml(option);

            var tempPath = Path.Combine(AppContext.BaseDirectory, "t1.xml");
            File.WriteAllText(tempPath, xml);

            var option2 = FDFSOptionHelper.GetFDFSOption(tempPath);
            Assert.Single(option2.Trackers);
            Assert.Equal("utf-8", option2.Charset);
            Assert.Equal(5, option2.ConnectionTimeout);
            Assert.Equal(3200, option2.ConnectionLifeTime);
            Assert.Equal(10, option2.ScanTimeoutConnectionInterval);
            Assert.Equal(5, option2.TrackerMaxConnection);
            Assert.Equal(20, option2.StorageMaxConnection);
            Assert.Equal("Name1", option2.LoggerName);
            Assert.Equal(30, option2.TcpSetting.QuietPeriodMilliSeconds);
            Assert.Equal(1, option2.TcpSetting.CloseTimeoutSeconds);
            Assert.Equal(16777216, option2.TcpSetting.WriteBufferHighWaterMark);
            Assert.Equal(8388608, option2.TcpSetting.WriteBufferLowWaterMark);
            Assert.Equal(1048576, option2.TcpSetting.SoRcvbuf);
            Assert.Equal(1048576, option2.TcpSetting.SoSndbuf);
            Assert.True(option2.TcpSetting.TcpNodelay);
            Assert.False(option2.TcpSetting.SoReuseaddr);
            Assert.True(option2.TcpSetting.EnableReConnect);
            Assert.Equal(3, option2.TcpSetting.ReConnectDelaySeconds);
            Assert.Equal(1001, option2.TcpSetting.ReConnectIntervalMilliSeconds);
            Assert.Equal(10, option2.TcpSetting.ReConnectMaxCount);
            File.Delete(tempPath);
        }

    }
}