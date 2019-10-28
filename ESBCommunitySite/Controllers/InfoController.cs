using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ESBCommunitySite.Models;
using Microsoft.AspNetCore.Mvc;

namespace ESBCommunitySite.Controllers
{
    public class InfoController : Controller
    {
        // Info method
        public ViewResult Info()
        {
            return View();
        }
        // Location method
        public ViewResult Location()
        {
            return View();
        }
        // Roster method
        public ViewResult Roster()
        {
            List<Member> currentRoster = new List<Member>();
            List<Member> flutes = new List <Member>(currentRoster.FilterByInstrument("flute"));
            List<Member> oboes = new List<Member>(currentRoster.FilterByInstrument("oboe"));
            List<Member> clarinets = new List<Member>(currentRoster.FilterByInstrument("clarinet"));
            List<Member> saxes = new List<Member>(currentRoster.FilterByInstrument("saxophone"));
            List<Member> horns = new List<Member>(currentRoster.FilterByInstrument("French horn"));
            List<Member> trumpets = new List<Member>(currentRoster.FilterByInstrument("trumpet"));
            List<Member> trombones = new List<Member>(currentRoster.FilterByInstrument("trombone"));
            List<Member> euphoniums = new List<Member>(currentRoster.FilterByInstrument("euphonium"));
            List<Member> tubas = new List<Member>(currentRoster.FilterByInstrument("tuba"));
            return View();
        }
        public ViewResult RosterByJoinDate()
        {
            List<Member> roster = Models.Roster.CurrentRoster;
            roster.Sort((r1, r2) => string.Compare(r1.DateJoined, r2.DateJoined, StringComparison.Ordinal));
            roster.Reverse();
            return View(roster);

        }
    }
}