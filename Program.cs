using System;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

namespace SchemaFromJson
{
    class Program
    {
        static void Main(string[] args)
        {
            var jsondata = @"{
                ""_id"": ""5cdb46266da15edda43c1464"",
                ""index"": 0,
                ""guid"": ""7878a6de-fc94-4efb-87c2-38614fa8543b"",
                ""isActive"": true,
                ""balance"": ""$3,932.58"",
                ""picture"": ""http://placehold.it/32x32"",
                ""age"": 20,
                ""eyeColor"": ""blue"",
                ""name"": ""Sharpe Faulkner"",
                ""gender"": ""male"",
                ""company"": ""GEEKETRON"",
                ""email"": ""sharpefaulkner@geeketron.com"",
                ""phone"": ""+1 (975) 544-2284"",
                ""address"": ""843 Surf Avenue, Alden, District Of Columbia, 1966"",
                ""about"": ""In tempor commodo est culpa anim. Anim ea amet veniam reprehenderit aliquip elit sit enim pariatur. Aliquip duis ex labore sunt eiusmod dolore veniam eu ex eiusmod. Esse consectetur minim cupidatat officia laboris sint nisi veniam aliqua. Ad duis culpa commodo consectetur Lorem ad officia nulla. Amet do excepteur pariatur occaecat exercitation cupidatat cupidatat aliqua exercitation consectetur.\r\n"",
                ""registered"": ""2019-02-20T06:45:46 +05:00"",
                ""latitude"": 17.76389,
                ""longitude"": 108.249262,
                ""tags"": [
                ""fugiat"",
                ""eu"",
                ""est"",
                ""eiusmod"",
                ""pariatur"",
                ""aliquip"",
                ""ex""
                ],
                ""friends"": [
                {
                    ""id"": 0,
                    ""name"": ""Leonard Davidson""
                },
                {
                    ""id"": 1,
                    ""name"": ""Allison Walton""
                },
                {
                    ""id"": 2,
                    ""name"": ""Spencer Nichols""
                }
                ],
                ""greeting"": ""Hello, Sharpe Faulkner! You have 8 unread messages."",
                ""favoriteFruit"": ""strawberry""
            }";

            JObject parsed = JObject.Parse(jsondata);

            foreach(JProperty p in parsed.Properties()){
                Console.WriteLine(p.Name +" - "+ p.Value.Type);
            }

            Console.WriteLine("SCHEMA");
            JSchema schema = JSchema.Parse(jsondata);
            foreach (var property in schema.Properties)
            {
                Console.WriteLine(property.Key + " : " + property.Value.Type);
            }
        }
    }
}
