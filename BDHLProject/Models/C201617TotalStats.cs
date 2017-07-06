namespace BDHLProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("201617TotalStats")]
    public partial class C201617TotalStats
    {
        [StringLength(255)]
        public string DOB { get; set; }

        [StringLength(255)]
        public string BirthCity { get; set; }

        [StringLength(255)]
        public string StateOrProvince { get; set; }

        [StringLength(255)]
        public string Country { get; set; }

        [StringLength(255)]
        public string Nationality { get; set; }

        public double? Height { get; set; }

        public double? Weight { get; set; }

        public double? Draft { get; set; }

        public double? Round { get; set; }

        public double? Overall { get; set; }

        [StringLength(255)]
        public string Shoots { get; set; }

        public double? F12 { get; set; }

        [StringLength(255)]
        public string LastName { get; set; }

        [StringLength(255)]
        public string FirstName { get; set; }

        [StringLength(255)]
        public string Position { get; set; }

        [StringLength(255)]
        public string Team { get; set; }

        [Column("Primary Stats")]
        public double? Primary_Stats { get; set; }

        public double? Goals { get; set; }

        public double? Assists { get; set; }

        public double? A1 { get; set; }

        public double? A2 { get; set; }

        public double? Points { get; set; }

        public double? PlusMinus { get; set; }

        public double? F24 { get; set; }

        public double? PIM { get; set; }

        public double? Shifts { get; set; }

        public double? TOITotal { get; set; }

        public double? TOIPerGame { get; set; }

        public double? F29 { get; set; }

        public double? F30 { get; set; }

        public double? F31 { get; set; }

        public double? F32 { get; set; }

        [Column("Key Team Stats")]
        public double? Key_Team_Stats { get; set; }

        public double? F34 { get; set; }

        public double? F35 { get; set; }

        public double? F36 { get; set; }

        public double? F37 { get; set; }

        public double? F38 { get; set; }

        public double? F39 { get; set; }

        public double? F40 { get; set; }

        [Column("Individual Stats")]
        public double? Individual_Stats { get; set; }

        public double? F42 { get; set; }

        public double? F43 { get; set; }

        public double? F44 { get; set; }

        public double? F45 { get; set; }

        public double? F46 { get; set; }

        public double? F47 { get; set; }

        public double? F48 { get; set; }

        public double? F49 { get; set; }

        public double? F50 { get; set; }

        public double? F51 { get; set; }

        public double? F52 { get; set; }

        public double? F53 { get; set; }

        public double? F54 { get; set; }

        public double? F55 { get; set; }

        public double? F56 { get; set; }

        public double? F57 { get; set; }

        public double? F58 { get; set; }

        public double? F59 { get; set; }

        public double? F60 { get; set; }

        public double? F61 { get; set; }

        public double? F62 { get; set; }

        public double? F63 { get; set; }

        public double? F64 { get; set; }

        public double? F65 { get; set; }

        public double? F66 { get; set; }

        public double? F67 { get; set; }

        public double? F68 { get; set; }

        public double? F69 { get; set; }

        public double? F70 { get; set; }

        public double? F71 { get; set; }

        public double? F72 { get; set; }

        public double? F73 { get; set; }

        public double? F74 { get; set; }

        public double? F75 { get; set; }

        public double? F76 { get; set; }

        public double? F77 { get; set; }

        public double? F78 { get; set; }

        public double? F79 { get; set; }

        public double? F80 { get; set; }

        public double? F81 { get; set; }

        public double? F82 { get; set; }

        public double? F83 { get; set; }

        public double? F84 { get; set; }

        public double? F85 { get; set; }

        public double? F86 { get; set; }

        public double? F87 { get; set; }

        public double? F88 { get; set; }

        public double? F89 { get; set; }

        public double? F90 { get; set; }

        public double? F91 { get; set; }

        public double? F92 { get; set; }

        public double? F93 { get; set; }

        public double? F94 { get; set; }

        public double? F95 { get; set; }

        public double? F96 { get; set; }

        public double? F97 { get; set; }

        public double? F98 { get; set; }

        public double? F99 { get; set; }

        public double? F100 { get; set; }

        public double? F101 { get; set; }

        public double? F102 { get; set; }

        public double? F103 { get; set; }

        public double? F104 { get; set; }

        public double? F105 { get; set; }

        public double? F106 { get; set; }

        public double? F107 { get; set; }

        public double? F108 { get; set; }

        public double? F109 { get; set; }

        public double? F110 { get; set; }

        public double? F111 { get; set; }

        public double? F112 { get; set; }

        public double? F113 { get; set; }

        public double? F114 { get; set; }

        public double? F115 { get; set; }

        public double? F116 { get; set; }

        public double? F117 { get; set; }

        public double? F118 { get; set; }

        public double? F119 { get; set; }

        [Column("Scoring-Based On-Ice Team Stats")]
        public double? Scoring_Based_On_Ice_Team_Stats { get; set; }

        public double? F121 { get; set; }

        public double? F122 { get; set; }

        public double? F123 { get; set; }

        public double? F124 { get; set; }

        public double? F125 { get; set; }

        public double? F126 { get; set; }

        public double? F127 { get; set; }

        public double? F128 { get; set; }

        public double? F129 { get; set; }

        public double? F130 { get; set; }

        public double? F131 { get; set; }

        public double? F132 { get; set; }

        public double? F133 { get; set; }

        public double? F134 { get; set; }

        public double? F135 { get; set; }

        public double? F136 { get; set; }

        public double? F137 { get; set; }

        [Column("Other On-Ice Team Stats")]
        public double? Other_On_Ice_Team_Stats { get; set; }

        public double? F139 { get; set; }

        public double? F140 { get; set; }

        public double? F141 { get; set; }

        public double? F142 { get; set; }

        public double? F143 { get; set; }

        public double? F144 { get; set; }

        public double? F145 { get; set; }

        [Column("Catch-All")]
        public double? Catch_All { get; set; }

        public double? F147 { get; set; }

        public double? F148 { get; set; }

        [StringLength(255)]
        public string Other { get; set; }

        [StringLength(255)]
        public string F150 { get; set; }

        [StringLength(255)]
        public string F151 { get; set; }

        public double? F152 { get; set; }

        public double? F153 { get; set; }

        public double? F154 { get; set; }

        public double? F155 { get; set; }

        public double? F156 { get; set; }

        public double? F157 { get; set; }

        public double? F158 { get; set; }

        public double? F159 { get; set; }

        public double? F160 { get; set; }

        [StringLength(255)]
        public string F161 { get; set; }

        [StringLength(255)]
        public string F162 { get; set; }

        [StringLength(255)]
        public string F163 { get; set; }

        [Column("Contract Information")]
        [StringLength(255)]
        public string Contract_Information { get; set; }

        [StringLength(255)]
        public string F165 { get; set; }

        [Column(TypeName = "money")]
        public decimal? F166 { get; set; }

        [Column(TypeName = "money")]
        public decimal? F167 { get; set; }

        [StringLength(255)]
        public string F168 { get; set; }

        [StringLength(255)]
        public string F169 { get; set; }

        [StringLength(255)]
        public string F170 { get; set; }

        [StringLength(255)]
        public string F171 { get; set; }

        [StringLength(255)]
        public string F172 { get; set; }

        [StringLength(255)]
        public string F173 { get; set; }

        [StringLength(255)]
        public string F174 { get; set; }

        [StringLength(255)]
        public string F175 { get; set; }

        [StringLength(255)]
        public string F176 { get; set; }

        [StringLength(255)]
        public string F177 { get; set; }

        [StringLength(255)]
        public string F178 { get; set; }

        [StringLength(255)]
        public string F179 { get; set; }

        [StringLength(255)]
        public string F180 { get; set; }

        [StringLength(255)]
        public string F181 { get; set; }

        [StringLength(255)]
        public string F182 { get; set; }

        [StringLength(255)]
        public string F183 { get; set; }

        [StringLength(255)]
        public string F184 { get; set; }

        [StringLength(255)]
        public string F185 { get; set; }

        [StringLength(255)]
        public string F186 { get; set; }

        [StringLength(255)]
        public string F187 { get; set; }

        [StringLength(255)]
        public string F188 { get; set; }

        [StringLength(255)]
        public string F189 { get; set; }

        [StringLength(255)]
        public string F190 { get; set; }

        [StringLength(255)]
        public string F191 { get; set; }

        [StringLength(255)]
        public string F192 { get; set; }

        [StringLength(255)]
        public string F193 { get; set; }

        [StringLength(255)]
        public string F194 { get; set; }

        [StringLength(255)]
        public string F195 { get; set; }

        [StringLength(255)]
        public string F196 { get; set; }

        [StringLength(255)]
        public string F197 { get; set; }

        [StringLength(255)]
        public string F198 { get; set; }

        [StringLength(255)]
        public string F199 { get; set; }

        [StringLength(255)]
        public string F200 { get; set; }

        [StringLength(255)]
        public string F201 { get; set; }

        [StringLength(255)]
        public string F202 { get; set; }

        [StringLength(255)]
        public string F203 { get; set; }

        [StringLength(255)]
        public string F204 { get; set; }

        [StringLength(255)]
        public string F205 { get; set; }

        [StringLength(255)]
        public string F206 { get; set; }

        [StringLength(255)]
        public string F207 { get; set; }

        [StringLength(255)]
        public string F208 { get; set; }

        [StringLength(255)]
        public string F209 { get; set; }

        [StringLength(255)]
        public string F210 { get; set; }

        [StringLength(255)]
        public string F211 { get; set; }

        [StringLength(255)]
        public string F212 { get; set; }

        [StringLength(255)]
        public string F213 { get; set; }

        [StringLength(255)]
        public string F214 { get; set; }

        [StringLength(255)]
        public string F215 { get; set; }

        [StringLength(255)]
        public string F216 { get; set; }

        [StringLength(255)]
        public string F217 { get; set; }

        [StringLength(255)]
        public string F218 { get; set; }

        [StringLength(255)]
        public string F219 { get; set; }

        [StringLength(255)]
        public string F220 { get; set; }

        [StringLength(255)]
        public string F221 { get; set; }

        [StringLength(255)]
        public string F222 { get; set; }

        [StringLength(255)]
        public string F223 { get; set; }

        [StringLength(255)]
        public string F224 { get; set; }

        [StringLength(255)]
        public string F225 { get; set; }

        [StringLength(255)]
        public string F226 { get; set; }

        [StringLength(255)]
        public string F227 { get; set; }

        [StringLength(255)]
        public string F228 { get; set; }

        [StringLength(255)]
        public string F229 { get; set; }

        [StringLength(255)]
        public string F230 { get; set; }

        [StringLength(255)]
        public string F231 { get; set; }

        [StringLength(255)]
        public string F232 { get; set; }

        [StringLength(255)]
        public string F233 { get; set; }

        [StringLength(255)]
        public string F234 { get; set; }

        [StringLength(255)]
        public string F235 { get; set; }

        [StringLength(255)]
        public string F236 { get; set; }

        [StringLength(255)]
        public string F237 { get; set; }

        [StringLength(255)]
        public string F238 { get; set; }

        [StringLength(255)]
        public string F239 { get; set; }

        [StringLength(255)]
        public string F240 { get; set; }

        [StringLength(255)]
        public string F241 { get; set; }

        [StringLength(255)]
        public string F242 { get; set; }

        [StringLength(255)]
        public string F243 { get; set; }

        [StringLength(255)]
        public string F244 { get; set; }

        [StringLength(255)]
        public string F245 { get; set; }

        [StringLength(255)]
        public string F246 { get; set; }

        [StringLength(255)]
        public string F247 { get; set; }

        [StringLength(255)]
        public string F248 { get; set; }

        [StringLength(255)]
        public string F249 { get; set; }

        [StringLength(255)]
        public string F250 { get; set; }

        [StringLength(255)]
        public string F251 { get; set; }

        [StringLength(255)]
        public string F252 { get; set; }

        [StringLength(255)]
        public string F253 { get; set; }

        [StringLength(255)]
        public string F254 { get; set; }

        [StringLength(255)]
        public string F255 { get; set; }

        [Key]
        public int id { get; set; }
    }
}
