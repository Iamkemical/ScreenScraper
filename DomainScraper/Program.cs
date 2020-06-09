using System.Net;
using System.Text;
using System.Net.Http;
using System;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace DomainScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            var url1 = "https://cpanel.annashut.com";
            var uri1 = new Uri(url1);
            //Extracts cpanel
            string myJson1 = uri1.Host.Substring(0,6);
            
           //Sending subdomain as Json
            using(var client = new HttpClient())
            {
                var response =  client.PostAsync(
                    "https://domain.annashut.com",
                    new StringContent(myJson1, Encoding.UTF8, "application/json"));
            } 

            var url2 = "https://domain.annashut.com";
            var uri2 = new Uri(url2);

            //Extracts domain
            var myJson2 = uri2.Host.Substring(0,6);

            //Sending subdomain as Json
            using(var client = new HttpClient())
            {
                var response =  client.PostAsync(
                    "https://domain.annashut.com",
                    new StringContent(myJson2, Encoding.UTF8, "application/json"));
            } 

            var url3 = "https://hngi7.annashut.com";
            var uri3 = new Uri(url3);

            //Extracts hngi7
            var myJson3 = uri3.Host.Substring(0,5);

            //Sending subdomain as Json
            using(var client = new HttpClient())
            {
                var response =  client.PostAsync(
                    "https://hngi7.annashut.com",
                    new StringContent(myJson3, Encoding.UTF8, "application/json"));
            } 
            
            var url4 = "https://mail.annashut.com";
            var uri4 = new Uri(url4);

            //Extracts mail
            var myJson4 = uri4.Host.Substring(0,4);

            //Sending subdomain as Json
            using(var client = new HttpClient())
            {
                var response =  client.PostAsync(
                    "https://mail.annashut.com",
                    new StringContent(myJson4, Encoding.UTF8, "application/json"));
            } 

            var url5 = "https://test.annashut.com";
            var uri5 = new Uri(url5);
            
            //Extracts test
            var myJson5 = uri5.Host.Substring(0,4);

             //Sending subdomain as Json
            using(var client = new HttpClient())
            {
                var response =  client.PostAsync(
                    "https://test.annashut.com",
                    new StringContent(myJson5, Encoding.UTF8, "application/json"));
            } 

            var url6 = "https://webdisk.annashut.com";
            var uri6 = new Uri(url6);

            //Extracts webdisk
            var myJson6 = uri6.Host.Substring(0,7);

             //Sending subdomain as Json
            using(var client = new HttpClient())
            {
                var response =  client.PostAsync(
                    "https://test.annashut.com",
                    new StringContent(myJson6, Encoding.UTF8, "application/json"));
            } 

            var url7 = "https://webmail.annashut.com";
            var uri7 = new Uri(url7);

            //Extracts webmail
            var myJson7 = uri7.Host.Substring(0,7);

             //Sending subdomain as Json
            using(var client = new HttpClient())
            {
                var response =  client.PostAsync(
                    "https://test.annashut.com",
                    new StringContent(myJson7, Encoding.UTF8, "application/json"));
            } 

            var url8 = "https://www.annashut.com";
            var uri8 = new Uri(url8);

            //Extracts www
            var myJson8 = uri8.Host.Substring(0,3);

              //Sending subdomain as Json
            using(var client = new HttpClient())
            {
                var response =  client.PostAsync(
                    "https://test.annashut.com",
                    new StringContent(myJson8, Encoding.UTF8, "application/json"));
            } 
        }
    }
}
