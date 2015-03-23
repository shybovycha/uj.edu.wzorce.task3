using System;
using System.Text.RegularExpressions;

namespace task3
{
    public class InputParser
    {
        private IPociagowaFabryka fabric;
        private bool flOsi;

        public InputParser()
        {
        }

        public IWagon createWagon(String typStr)
        {
            String typ = parseTypWagonu(typStr);

            if (typ == "Towarowy") {
                return this.fabric.createTowarowyWagon();
            } else if (typ == "Osobowy") {
                return this.fabric.createOsobowyWagon();
            }

            throw new ArgumentException("Zły typ wagonu");
        }

        public ILokomotywa createLokomotywa(String typStr)
        {
            String typ = parseTypLokomotywy(typStr);

            if (flOsi) {
                this.fabric = new OsiowaFabryka();
            } else {
                this.fabric = new ZwyklaFabryka();
            }

            if (typ == "Elektryczna") {
                return this.fabric.createElektrycznaLokomotywa();
            } else if (typ == "Spalinowa") {
                return this.fabric.createSpalinowaLokomotywa();
            }

            throw new ArgumentException("Zły typ lokomotywy");
        }

        protected int parseDlugosc(String s)
        {
            return Int32.Parse(s);
        }

        protected String parseTypLokomotywy(String s)
        {
            Match match = Regex.Match(s, @"^(O)?\s*(E|S)$");
            String typ = "";

            this.flOsi = false;

            if (match.Success) {
                if (match.Groups[1].Value == "O") {
                    this.flOsi = true;
                }

                if (match.Groups[2].Value == "E") {
                    typ = "Elektryczna";
                } else if (match.Groups[2].Value == "S") {
                    typ = "Spalinowa";
                } else {
                    typ = "Unknown";
                }
            }

            return typ;
        }

        protected String parseTypWagonu(String s)
        {
            Match match = Regex.Match(s, @"^(T|B)$");
            String typ = "";

            if (match.Success) {
                if (match.Groups[1].Value == "T") {
                    typ = "Towarowy";
                } else if (match.Groups[1].Value == "B") {
                    typ = "Osobowy";
                } else {
                    typ = "Unknown";
                }
            }

            return typ;
        }
    }
}

