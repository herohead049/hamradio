

using Gremlin.CallSignResponse;
using Neo4jClient;
using System;
using System.Net;

namespace Gremlin
{
    class Program
    {
        static void Main(string[] args)
        {

            // var _driver = GraphDatabase.Driver("bolt://192.168.50.231:7687", AuthTokens.Basic("neo4j", "qwerty"));
            var nclient = new GraphClient(new Uri("http://192.168.50.231:7474/db/data"), "neo4j", "qwerty");

            var client = new WebClient();
            var call = "IK4OMO";
            var content = client.DownloadString($"http://callook.info/{call}/json");

            var res = Newtonsoft.Json.JsonConvert.DeserializeObject<CallsignResponse>(content);
            nclient.Connect();

            var callSign = new CallSign
            {
                Name = res.current.callsign,
                AddressAttn = res.address.attn,
                AddressLine1 = res.address.line1,
                AddressLine2 = res.address.line2,
                Callsign = res.current.callsign,
                ExpiryDate = res.otherInfo.expiryDate,
                Frn = res.otherInfo.frn,
                GrantDate = res.otherInfo.grantDate,
                Gridsquare = res.location.gridsquare,
                LastActionDate = res.otherInfo.lastActionDate,
                Latitude = res.location.latitude,
                Longitude = res.location.longitude,
                Handle = res.name,
                OperClass = res.current.operClass,
                PreCallsign = res.previous.callsign,
                PreOperClass = res.previous.operClass,
                Status = res.status,
                TrusteeCallsign = res.trustee.callsign,
                TrusteeName = res.trustee.name,
                Type = res.type,
                UlsURL = res.otherInfo.ulsURL
            };



            var r = nclient.Cypher
                .Create("(c:TestCallsign {callSign})")
                .WithParam("callSign", callSign);

            r.ExecuteWithoutResults();


            var message = "Hello World";

            //using (var session = _driver.Session())
            //{



            //    var greeting = session.WriteTransaction(tx =>
            //    {


            //        var result = tx.Run(q);



            //        //,
            //        //    new { message });



            //        return result.Single()[0].As<string>();
            //    });

            //    //greeting = session.ReadTransaction(tx =>
            //    //{

            //    //    var result = tx.Run("MATCH (a:Greeting) " +
            //    //                        "WHERE a.message = $message " +
            //    //                        "RETURN a.message",
            //    //        new { message });



            //    //    return result.Single()[0].As<string>();
            //    //});





            //    Console.WriteLine(greeting);
            //}


        }
    }
}
