using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ESBCommunitySite.Models
{
    public static class ExtensionMethods
    {
        public static IEnumerable<Member> FilterByInstrument(this IEnumerable<Member> memberEnum, string instrument)
        {
            List<Member> members = new List<Member>();
            foreach (Member memb in members)
            {
                if(memb.Instrument == instrument)
                {
                    yield return memb;
                }
            }
        }
    }
}
