using System;
using GTANetworkAPI;

namespace whitelist
{

    class SoulVPNBlocker : Script
    {


        [ServerEvent(Event.PlayerConnected)]
        public void OnPlayerConnected(Client player)
        {
            var vpnfrisk = NAPI.Player.GetPlayerAddress(player);

            /*
             * You may wonder why we are using our own set of IP's to block instead
             * of a already prebuilt system? Well the answer is quite simple, if that
             * source goes down it will start throwing errors and not block the IP's that may
             * be VPN's. Another concern may be well this will make the file size larger and
             * make my clients load longer. Now this can be very true but modern internet connections 
             * can download in megabits per second which this file stays under 1 mb which may
             * change in the future as more IP's are added. Another question to answer is where are these
             * IP's coming from? We are using actual VPN services and VPN IP list.
            */

            if (vpnfrisk.Equals("59.15.205.233") ||
                (vpnfrisk.Equals("119.175.155.76")) ||
                (vpnfrisk.Equals("121.168.45.38")) ||
                (vpnfrisk.Equals("210.217.15.184")) ||
                (vpnfrisk.Equals("36.227.11.88")) ||
                (vpnfrisk.Equals("1.238.79.152	")) ||
                (vpnfrisk.Equals("190.146.125.73")) ||
                (vpnfrisk.Equals("219.118.121.76")) ||
                (vpnfrisk.Equals("210.216.247.139")) ||
                (vpnfrisk.Equals("126.73.112.52")) ||
                (vpnfrisk.Equals("211.55.193.55")) ||
                (vpnfrisk.Equals("184.82.77.15")) ||
                (vpnfrisk.Equals("203.250.64.104")) ||
                (vpnfrisk.Equals("121.153.45.35")) ||
                (vpnfrisk.Equals("190.19.247.42")) ||
                (vpnfrisk.Equals("110.163.143.10")) ||
                (vpnfrisk.Equals("222.1.90.63")) ||
                (vpnfrisk.Equals("61.74.24.104")) ||
                (vpnfrisk.Equals("220.218.70.177")) ||
                (vpnfrisk.Equals("221.119.221.214")) ||
                (vpnfrisk.Equals("114.149.162.239")) ||
                (vpnfrisk.Equals("118.159.64.174")) ||
                (vpnfrisk.Equals("211.207.136.174")) ||
                (vpnfrisk.Equals("218.217.124.231")) ||
                (vpnfrisk.Equals("49.142.59.140")) ||
                (vpnfrisk.Equals("73.239.14.25")) ||
                (vpnfrisk.Equals("175.131.191.196")) ||
                (vpnfrisk.Equals("218.158.82.201")) ||
                (vpnfrisk.Equals("163.131.152.156")) ||
                (vpnfrisk.Equals("121.163.44.82")) ||
                (vpnfrisk.Equals("119.56.211.14")) ||
                (vpnfrisk.Equals("42.150.164.42")) ||
                (vpnfrisk.Equals("220.79.64.222")) ||
                (vpnfrisk.Equals("118.155.104.114")) ||
                (vpnfrisk.Equals("211.212.83.229")) ||
                (vpnfrisk.Equals("118.32.76.189")) ||
                (vpnfrisk.Equals("14.43.233.121")) ||
                (vpnfrisk.Equals("39.116.21.17")) ||
                (vpnfrisk.Equals("180.66.251.190")) ||
                (vpnfrisk.Equals("180.68.31.121")) ||
                (vpnfrisk.Equals("175.210.230.179")) ||
                (vpnfrisk.Equals("78.85.4.30")) ||
                (vpnfrisk.Equals("65.99.66.107")) ||
                (vpnfrisk.Equals("184.22.58.167")) ||
                (vpnfrisk.Equals("65.27.53.112")) ||
                (vpnfrisk.Equals("119.196.48.137")) ||
                (vpnfrisk.Equals("121.151.168.38")) ||
                (vpnfrisk.Equals("121.130.188.116")) ||
                (vpnfrisk.Equals("106.171.72.249")) ||
                (vpnfrisk.Equals("210.136.183.107")) ||
                (vpnfrisk.Equals("39.113.183.212")) ||
                (vpnfrisk.Equals("1.4.186.192")) ||
                (vpnfrisk.Equals("101.99.74.214")) ||
                (vpnfrisk.Equals("27.6.71.123")) ||
                (vpnfrisk.Equals("45.32.253.161")) ||
                (vpnfrisk.Equals("202.182.126.55")) ||
                (vpnfrisk.Equals("210.210.220.138")) ||
                (vpnfrisk.Equals("114.109.124.64")) ||
                (vpnfrisk.Equals("115.31.86.155")) ||
                (vpnfrisk.Equals("171.247.24.192")) ||
                (vpnfrisk.Equals("46.28.204.34")) ||
                (vpnfrisk.Equals("218.148.113.35")) ||
                (vpnfrisk.Equals("121.129.222.165")) ||
                (vpnfrisk.Equals("121.158.57.140")) ||
                (vpnfrisk.Equals("37.228.129.81")) ||
                (vpnfrisk.Equals("207.148.111.200")) ||
                (vpnfrisk.Equals("200.2.166.122")) ||
                (vpnfrisk.Equals("184.22.37.153")) ||
                (vpnfrisk.Equals("46.251.76.70")) ||
                (vpnfrisk.Equals("183.91.3.207")) ||
                (vpnfrisk.Equals("178.150.171.2")) ||
                (vpnfrisk.Equals("124.217.249.24")) ||
                (vpnfrisk.Equals("87.10.119.245")) ||
                (vpnfrisk.Equals("181.117.160.128")) ||
                (vpnfrisk.Equals("1.11.72.97")) ||
                (vpnfrisk.Equals("103.250.73.38")) ||
                (vpnfrisk.Equals("181.224.242.142")) ||
                (vpnfrisk.Equals("115.77.125.26")) ||
                (vpnfrisk.Equals("59.126.153.250")) ||
                (vpnfrisk.Equals("95.24.28.31")) ||
                (vpnfrisk.Equals("104.244.225.126")) ||
                (vpnfrisk.Equals("175.212.91.131")) ||
                (vpnfrisk.Equals("126.107.51.73")) ||
                (vpnfrisk.Equals("103.216.218.19")) ||
                (vpnfrisk.Equals("45.77.132.48")) ||
                (vpnfrisk.Equals("222.114.60.79")) ||
                (vpnfrisk.Equals("223.133.27.59")) ||
                (vpnfrisk.Equals("37.120.154.14")) ||
                (vpnfrisk.Equals("126.187.69.70")) ||
                (vpnfrisk.Equals("103.201.129.74")) ||
                (vpnfrisk.Equals("200.1.183.118")) ||
                (vpnfrisk.Equals("211.203.11.53")) ||
                (vpnfrisk.Equals("14.240.20.224")) ||
                (vpnfrisk.Equals("182.221.196.19")) ||
                (vpnfrisk.Equals("88.232.254.154")) ||
                (vpnfrisk.Equals("203.232.195.82")) ||
                (vpnfrisk.Equals("211.236.143.56")) ||
                (vpnfrisk.Equals("182.165.6.166")) ||
                (vpnfrisk.Equals("153.137.207.219")) ||
                (vpnfrisk.Equals("109.184.218.45")) ||
                (vpnfrisk.Equals("118.168.16.78")) ||
                (vpnfrisk.Equals("178.129.33.168")) ||
                (vpnfrisk.Equals("114.18.140.186")) ||
                (vpnfrisk.Equals("184.148.235.157")) ||
                (vpnfrisk.Equals("24.14.72.83")) ||
                (vpnfrisk.Equals("59.14.248.182")) ||
                (vpnfrisk.Equals("60.90.200.30")) ||
                (vpnfrisk.Equals("133.232.126.9")) ||
                (vpnfrisk.Equals("36.237.207.116")) ||
                (vpnfrisk.Equals("139.192.172.109")) ||
                (vpnfrisk.Equals("112.168.28.29")) ||
                (vpnfrisk.Equals("39.110.135.35")) ||
                (vpnfrisk.Equals("122.196.196.30")) ||
                (vpnfrisk.Equals("121.93.146.46")) ||
                (vpnfrisk.Equals("126.235.200.204")) ||
                (vpnfrisk.Equals("210.148.184.234")) ||
                (vpnfrisk.Equals("39.42.105.168")) ||
                (vpnfrisk.Equals("220.120.234.6")) ||
                (vpnfrisk.Equals("180.34.62.181")) ||
                (vpnfrisk.Equals("79.214.248.58")) ||
                (vpnfrisk.Equals("1.253.94.66")) ||
                (vpnfrisk.Equals("220.209.90.30")) ||
                (vpnfrisk.Equals("117.207.120.147")) ||
                (vpnfrisk.Equals("124.59.108.182")) ||
                (vpnfrisk.Equals("49.143.96.34")) ||
                (vpnfrisk.Equals("180.183.104.8")) ||
                (vpnfrisk.Equals("39.40.66.87")) ||
                (vpnfrisk.Equals("223.16.100.195")) ||
                (vpnfrisk.Equals("49.167.174.120")) ||
                (vpnfrisk.Equals("221.255.222.173")) ||
                (vpnfrisk.Equals("117.203.219.127")) ||
                (vpnfrisk.Equals("121.141.189.14")) ||
                (vpnfrisk.Equals("182.231.165.138")) ||
                (vpnfrisk.Equals("90.63.246.230")) ||
                (vpnfrisk.Equals("113.173.86.92")) ||
                (vpnfrisk.Equals("212.241.18.214")) ||
                (vpnfrisk.Equals("39.122.180.110")) ||
                (vpnfrisk.Equals("98.249.71.51")) ||
                (vpnfrisk.Equals("115.126.218.109")) ||
                (vpnfrisk.Equals("90.161.123.178")) ||
                (vpnfrisk.Equals("117.193.189.197")) ||
                (vpnfrisk.Equals("117.198.21.153")) ||
                (vpnfrisk.Equals("118.136.52.7")) ||
                (vpnfrisk.Equals("202.216.19.81")) ||
                (vpnfrisk.Equals("109.91.37.4")) ||
                (vpnfrisk.Equals("112.197.191.6")) ||
                (vpnfrisk.Equals("36.38.47.24")) ||
                (vpnfrisk.Equals("176.36.130.51")) ||
                (vpnfrisk.Equals("171.241.200.139")) ||
                (vpnfrisk.Equals("5.3.247.116")) ||
                (vpnfrisk.Equals("58.225.78.80")) ||
                (vpnfrisk.Equals("110.13.193.115")) ||
                (vpnfrisk.Equals("110.76.110.117")) ||
                (vpnfrisk.Equals("192.111.140.235")) || // BetterNet VPN Service
                (vpnfrisk.Equals("104.232.37.151")) || // BetterNet VPN Service
                (vpnfrisk.Equals("54.164.234.179")) || // BetterNet VPN Service
                (vpnfrisk.Equals("52.0.79.127")) || // BetterNet VPN Service
                (vpnfrisk.Equals("66.7.64.0")) || // BetterNet VPN Service
                (vpnfrisk.Equals("63.92.12.0")) || // BetterNet VPN Service
                (vpnfrisk.Equals("63.238.12.0")) || // BetterNet VPN Service
                (vpnfrisk.Equals("63.238.16.0")) || // BetterNet VPN Service
                (vpnfrisk.Equals("208.47.248.0")) || // BetterNet VPN Service
                (vpnfrisk.Equals("209.201.96.0")) || // BetterNet VPN Service
                (vpnfrisk.Equals("50.19.128.0")) || // BetterNet VPN Service
                (vpnfrisk.Equals("107.20.0.0")) || // BetterNet VPN Service
                (vpnfrisk.Equals("107.22.0.0")) || // BetterNet VPN Service
                (vpnfrisk.Equals("107.150.30.168")) || // Windscribe VPN Service
                (vpnfrisk.Equals("155.94.250.92")) || // Windscribe VPN Service
                (vpnfrisk.Equals("107.150.30.144")) || // Windscribe VPN Service
                (vpnfrisk.Equals("107.150.30.145")) || // Windscribe VPN Service
                (vpnfrisk.Equals("107.150.30.147")) || // Windscribe VPN Service
                (vpnfrisk.Equals("107.150.30.156")) || // Windscribe VPN Service
                (vpnfrisk.Equals("107.150.30.139")) || // Windscribe VPN Service
                (vpnfrisk.Equals("155.94.250.74")) || // Windscribe VPN Service
                (vpnfrisk.Equals("155.94.250.105")) || // Windscribe VPN Service
                (vpnfrisk.Equals("155.94.250.115")) || // Windscribe VPN Service
                (vpnfrisk.Equals("104.129.18.224")) || // Windscribe VPN Service
                (vpnfrisk.Equals("173.44.48.21")) || // Windscribe VPN Service
                (vpnfrisk.Equals("68.235.38.57")) || // Windscribe VPN Service
                (vpnfrisk.Equals("185.236.200.26")) || // Windscribe VPN Service
                (vpnfrisk.Equals("82.102.22.43")) || // Windscribe VPN Service
                (vpnfrisk.Equals("82.102.24.33")) || // Windscribe VPN Service
                (vpnfrisk.Equals("185.20.99.188")) || // Windscribe VPN Service
                vpnfrisk.Equals("219.97.24.221"))
            {
                NAPI.Notification.SendNotificationToPlayer(player, "You are using a VPN!", true);
                Console.WriteLine(vpnfrisk + " - IP Blocked[VPN]");
                NAPI.Player.KickPlayer(player, "Denied");
            }
            else
            {

            }
        }




    }
}