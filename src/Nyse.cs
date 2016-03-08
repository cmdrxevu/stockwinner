namespace MarcoWagner.StockWinner
{
	internal class Nyse
	{
		public static readonly string[] Symbols = 
new []{"DDD",
"MMM",
"WBAI",
"WUBA",
"AHC",
"ATEN",
"AAC",
"AIR",
"AAN",
"ABB",
"ABT",
"ABBV",
"ANF",
"GCH",
"JEQ",
"SGF",
"ABM",
"AKR",
"ACN",
"ACCO",
"ACW",
"ACE",
"ATV",
"ATU",
"AYI",
"ADX",
"PEO",
"AGRO",
"ADPT",
"ADT",
"AAP",
"WMS",
"ASX",
"AAV",
"ATE",
"AVK",
"AGC",
"LCM",
"ACM",
"ANW",
"AEB",
"AED",
"AEG",
"AEH",
"AEK",
"AER",
"HIVE",
"AJRD",
"ARO",
"AET",
"AMG",
"MGR",
"AFL",
"AFSD",
"MITT",
"MITT^A",
"MITT^B",
"AGCO",
"A",
"GAS",
"AEM",
"ADC",
"GRO",
"AGU",
"AL",
"APD",
"AYR",
"ARG",
"AKS",
"ALP^O",
"ALG",
"AGI",
"ALK",
"AIN",
"ALB",
"ALU",
"AA",
"AA^B",
"ALR",
"ALR^B",
"ALEX",
"ALX",
"ARE",
"ARE^D",
"ARE^E",
"BABA",
"Y",
"ATI",
"ALLE",
"AGN",
"AGN^A",
"ALE",
"AKP",
"ADS",
"AFB",
"AOI",
"AWF",
"AB",
"ACG",
"LNT",
"NCV",
"NCZ",
"ACV",
"NIE",
"NFJ",
"AWH",
"ALSN",
"ALL",
"ALL^A",
"ALL^B",
"ALL^C",
"ALL^D",
"ALL^E",
"ALL^F",
"ALLY",
"ALLY^A",
"ALLY^B",
"BSI",
"ALJ",
"ALDW",
"AGD",
"AWP",
"AOD",
"RESI",
"MO",
"ACH",
"AMBR",
"ABEV",
"AMC",
"AMFW",
"AEE",
"AMRC",
"AMX",
"AAT",
"AXL",
"ACC",
"AEO",
"AEP",
"AEL",
"AXP",
"AFA",
"AFG",
"AFGE",
"AFGH",
"AFW",
"AMH",
"AMH^A",
"AMH^B",
"AMH^C",
"AIG",
"AIG.WS",
"AMID",
"ARL",
"ARPI",
"AWR",
"AMT",
"AMT^A",
"AMT^B",
"AVD",
"AWK",
"APU",
"AMP",
"ABC",
"ANFI",
"AHS",
"AP",
"APH",
"BETR",
"AXR",
"AME",
"AFSI^A",
"AFSI^B",
"AFSI^C",
"AFSI^D",
"AFSS",
"AFST",
"AEUA",
"APC",
"AU",
"BUD",
"AXE",
"NLY",
"NLY^A",
"NLY^C",
"NLY^D",
"AM",
"AR",
"ANTM",
"ANTX",
"ANH",
"ANH^A",
"ANH^B",
"ANH^C",
"AON",
"APA",
"AIV",
"AIV^A",
"AIV^Z",
"ARI",
"ARI^A",
"APO",
"AIB",
"AIY",
"AMTG",
"AMTG^A",
"AFT",
"AIF",
"APLE",
"AIT",
"ATR",
"WTR",
"ARMK",
"ABR",
"ABR^A",
"ABR^B",
"ABR^C",
"ABRN",
"ARC",
"ARCX",
"MT",
"MTCN",
"ARH^C",
"ACI",
"ADM",
"AROC",
"ARCO",
"ASC",
"AFC",
"ARU",
"ACRE",
"ARDC",
"ARES",
"AGX",
"ANET",
"AI",
"AIC",
"AIW",
"AHH",
"ARR",
"ARR^A",
"ARR^B",
"AWI",
"ARW",
"AJG",
"APAM",
"ASA",
"ABG",
"AHP",
"AHT",
"AHT^A",
"AHT^D",
"AHT^E",
"ASH",
"APB",
"GRR",
"ASPN",
"AHL",
"AHL^A",
"AHL^B",
"AHL^C",
"ASB",
"ASB^B",
"ASB^C",
"AC",
"AIZ",
"AGO",
"AGO^B",
"AGO^E",
"AGO^F",
"AF",
"AF^C",
"AZN",
"T",
"ATTO",
"AT",
"ATLS",
"ARP",
"ARP^D",
"ARP^E",
"ATO",
"ATW",
"AUO",
"ATHM",
"ALV",
"AN",
"AZO",
"AVB",
"AGR",
"ACP",
"AVY",
"AVG",
"AVH",
"AVA",
"AV",
"AVV",
"AVT",
"AVOL",
"AVP",
"AVX",
"AXTA",
"AXLL",
"AXS",
"AXS^C",
"AXS^D",
"AZUR",
"AZZ",
"BGS",
"BW",
"MCI",
"BGH",
"MPV",
"BMI",
"BHI",
"BBN",
"BLL",
"BGE^B",
"BANC",
"BANC^C",
"BANC^D",
"BOCA",
"BBVA",
"BBD",
"BBDO",
"BCH",
"BLX",
"BSBR",
"BSAC",
"SAN",
"SAN^A",
"SAN^B",
"SAN^C",
"SAN^I",
"CIB",
"BXS",
"BAC",
"BAC.WS.A",
"BAC.WS.B",
"BAC^D",
"BAC^E",
"BAC^I",
"BAC^L",
"BAC^W",
"BAC^Y",
"BAC^Z",
"BML^G",
"BML^H",
"BML^I",
"BML^J",
"BML^L",
"BOH",
"BMO",
"BK",
"BK^C",
"BNS",
"RATE",
"BKU",
"BCS",
"BCS^",
"BCS^A",
"BCS^C",
"BCS^D",
"BNED",
"BKS",
"B",
"CUDA",
"ABX",
"BAS",
"BXLT",
"BAX",
"BTE",
"BBT",
"BBT^D",
"BBT^E",
"BBT^F",
"BBT^G",
"BFR",
"BBX",
"BCE",
"TZF",
"BZH",
"BDX",
"BDC",
"BXE",
"BEL",
"BMS",
"BHE",
"BRK.A",
"BRK.B",
"BHLB",
"BBY",
"BGCA",
"BHP",
"BBL",
"BIG",
"BH",
"BBG",
"BIOA",
"BIOA.WS",
"BMR",
"BIO",
"BIO.B",
"BITA",
"BKH",
"BKHU",
"BKFS",
"BSM",
"BJZ",
"BFZ",
"CII",
"BHK",
"HYT",
"BTZ",
"DSU",
"BHL",
"BGR",
"BDJ",
"EGF",
"FRA",
"BFO",
"BGT",
"BOE",
"BME",
"BAF",
"BKT",
"BGY",
"BKN",
"BTA",
"BIT",
"MUI",
"MNE",
"MUA",
"BPK",
"BKK",
"BIE",
"BBK",
"BBF",
"BYM",
"BFK",
"BTT",
"MEN",
"MUC",
"MUH",
"MHD",
"MFL",
"MUJ",
"MHN",
"MUE",
"MUS",
"MVT",
"MYC",
"MCA",
"MYD",
"MYF",
"MFT",
"MIY",
"MYJ",
"MYN",
"MPA",
"MQT",
"MYI",
"MQY",
"BNJ",
"BNY",
"BLH",
"BQH",
"BSE",
"BCX",
"BST",
"BSD",
"BUI",
"BLK",
"BGB",
"BGX",
"BSL",
"BLT",
"BCRH",
"BXC",
"BWP",
"BA",
"BCC",
"BCEI",
"BOOT",
"BAH",
"BWA",
"SAM",
"BXP",
"BXP^B",
"BSX",
"BOX",
"BYD",
"BP",
"BPT",
"BERY",
"BRC",
"BDN^E",
"BDN",
"LND",
"BAK",
"BRFS",
"BPI",
"BGG",
"BFAM",
"EAT",
"BCO",
"BMY",
"BRS",
"BRX",
"BR",
"BKD",
"BAM",
"BOXC",
"DTLA^",
"INF",
"HHY",
"BIP",
"BOI",
"BPY",
"BEP",
"HTR",
"BRO",
"BF.A",
"BF.B",
"BRT",
"BC",
"BT",
"BPL",
"BKE",
"BVN",
"BBW",
"BG",
"BURL",
"BWXT",
"CJES",
"BCR",
"BNK",
"GYB",
"PFH",
"CAB",
"CABO",
"CVC",
"CBT",
"COG",
"CACI",
"CAE",
"CAI",
"CAA",
"CAL",
"CCC",
"CRC",
"CWT",
"CALX",
"ELY",
"CPE",
"CPE^A",
"CPN",
"CBM",
"CPT",
"CCJ",
"CAM",
"CPB",
"CCG",
"CCG^A",
"CM",
"CNI",
"CNQ",
"CP",
"CAJ",
"CMN",
"COF",
"COF.WS",
"COF^C",
"COF^D",
"COF^F",
"COF^P",
"CSU",
"BXMT",
"CLA",
"CMO",
"CMO^E",
"CRR",
"CAH",
"CCP",
"CRCM",
"CSL",
"KMX",
"CCL",
"CUK",
"CRS",
"CSV",
"CRI",
"CSH",
"CAS",
"CSLT",
"CTLT",
"CTT",
"CAT",
"CATO",
"CBZ",
"CBL",
"CBL^D",
"CBL^E",
"CBO",
"IGR",
"CBG",
"CBS",
"CBS.A",
"CBX",
"CDI",
"CEB",
"FUN",
"CDR",
"CDR^B",
"CGI",
"CE",
"CLS",
"CEL",
"CPAC",
"CX",
"CNCO",
"CVE",
"CNC",
"CEN",
"CNP",
"EBR",
"EBR.B",
"CEE",
"CCS",
"CTL",
"CVO",
"CF",
"CGG",
"GIB",
"ECOM",
"CRL",
"CLDT",
"HELI",
"CKP",
"CMCM",
"CHGG",
"CHE",
"CC",
"CHMT",
"CHMI",
"CHK",
"CHK^D",
"CHKR",
"CHSP",
"CHSP^A",
"CPK",
"CVX",
"CBI",
"CHS",
"CIM",
"CO",
"STV",
"DL",
"CEA",
"CHN",
"CGA",
"LFC",
"MY",
"CHL",
"NPD",
"BORN",
"SNP",
"ZNH",
"CHA",
"CHU",
"XNY",
"CYD",
"ZX",
"CMG",
"CHH",
"CBK",
"CB",
"CHT",
"CHD",
"CBR",
"CIEN",
"CI",
"XEC",
"CBB",
"CBB^B",
"CNK",
"CINR",
"CIR",
"CIT",
"BLW",
"C",
"C.WS.A",
"C^C",
"C^J",
"C^K",
"C^L",
"C^N",
"C^P",
"CFG",
"CIA",
"CIO",
"CVEO",
"CIVI",
"CLC",
"CWEI",
"CLH",
"CCO",
"CBA",
"CEM",
"EMO",
"CTR",
"CLW",
"CNL",
"CLF",
"CLV",
"CLX",
"CLD",
"MYCC",
"CMS",
"CMS^B",
"CNA",
"CNHI",
"CNO",
"CEO",
"CNXC",
"COH",
"CIE",
"KOF",
"KO",
"CCE",
"CDE",
"FOF",
"INB",
"UTF",
"LDP",
"MIE",
"RQI",
"RNP",
"PSF",
"RFI",
"CNS",
"CFX",
"CL",
"CXE",
"CIF",
"CXH",
"CMU",
"CLNY",
"CLNY^A",
"CLNY^B",
"CLNY^C",
"CPGX",
"CPPL",
"CXP",
"STK",
"CCV",
"CCZ",
"CMA",
"CMA.WS",
"FIX",
"CMC",
"CBU",
"CYH",
"CHCT",
"CIG",
"CIG.C",
"CBD",
"SBS",
"ELP",
"CCU",
"CODI",
"CMP",
"CSC",
"CRK",
"CAG",
"CXO",
"CCM",
"CNNX",
"COP",
"CNX",
"ED",
"STZ",
"STZ.B",
"CSTM",
"TCS",
"CBPX",
"CLR",
"VLRS",
"CVG",
"COO",
"CTB",
"CPS",
"CPA",
"CLB",
"CLGX",
"CORR",
"CORR^A",
"COR",
"COR^A",
"GLW",
"BCA",
"GYC",
"OFC",
"OFC^L",
"CXW",
"CZZ",
"CMRE",
"CMRE^B",
"CMRE^C",
"CMRE^D",
"COT",
"COTY",
"CCSC",
"CFC^A",
"CFC^B",
"CUZ",
"CVA",
"CPF",
"CPL",
"CR",
"CRD.A",
"CRD.B",
"BAP",
"CS",
"CPG",
"CEQP",
"CRH",
"CRT",
"CAPL",
"CCI",
"CCI^A",
"CCK",
"CRY",
"CSRA",
"CSS",
"CST",
"CTS",
"CUBE",
"CUBE^A",
"CUB",
"CFR",
"CFR^A",
"CFI",
"CMI",
"CW",
"SRF",
"SZC",
"CUBI",
"CUBI^C",
"CUBS",
"CSI",
"CVT",
"CVI",
"UAN",
"CVRR",
"CVS",
"CELP",
"CYS",
"CYS^A",
"CYS^B",
"DHI",
"DAN",
"DHR",
"DAC",
"DQ",
"DRI",
"DAR",
"DVA",
"DPM",
"DCT",
"DDR",
"DDR^J",
"DDR^K",
"DF",
"DECK",
"DE",
"DEX",
"DDF",
"DKL",
"DK",
"DLPH",
"DAL",
"DEL",
"DLX",
"DMD",
"DWRE",
"DNR",
"DKT",
"DB",
"DTK",
"DXB",
"DVN",
"DV",
"DHX",
"DHT",
"DEO",
"DO",
"DRII",
"DRH",
"DSX",
"DSX^B",
"DSXN",
"DKS",
"DBD",
"DLR",
"DLR^E",
"DLR^F",
"DLR^G",
"DLR^H",
"DLR^I",
"DGI",
"DDS",
"DDT",
"DIN",
"DPLO",
"DFS",
"DFS^B",
"DRA",
"DNI",
"DLB",
"DG",
"DDC",
"DM",
"DOM",
"D",
"DCUA",
"DCUB",
"DCUC",
"DPZ",
"UFS",
"DCI",
"LPG",
"DSL",
"DBL",
"PLOW",
"DEI",
"DOV",
"DDE",
"DVD",
"DOW",
"DPS",
"RDY",
"DRD",
"DW",
"DHF",
"DMB",
"DSM",
"LEO",
"DRQ",
"DST",
"DSW",
"DTE",
"DTQ",
"DTZ",
"DCO",
"DPG",
"DSE",
"DNP",
"DTF",
"DUC",
"DUK",
"DUKH",
"DRE",
"DNB",
"DFT",
"DFT^A",
"DFT^B",
"DHG",
"DY",
"DLNG",
"DLNG^A",
"DYN",
"DYN.WS",
"DYN^A",
"DX",
"DX^A",
"DX^B",
"DD",
"DD^A",
"DD^B",
"SSP",
"EGIF",
"EXP",
"ECC",
"ECCA",
"ECCZ",
"DEA",
"EGP",
"EMN",
"KODK",
"KODK.WS",
"KODK.WS.A",
"ETN",
"ETV",
"ETW",
"EV",
"EOI",
"EOS",
"EFT",
"EFF",
"ETX",
"EOT",
"EVN",
"ETJ",
"EFR",
"EVF",
"EVG",
"EVT",
"ETO",
"EXD",
"ETG",
"ETB",
"ETY",
"EXG",
"ECT",
"ECR",
"ECL",
"DANG",
"EC",
"EIX",
"EDR",
"EW",
"EHIC",
"EJ",
"EP^C",
"EE",
"EGO",
"LLY",
"ELLI",
"EFC",
"EARN",
"AKO.A",
"AKO.B",
"ERJ",
"EMC",
"EME",
"EMES",
"EBS",
"EMG",
"EMR",
"EDE",
"ESRT",
"EIG",
"EDN",
"EOC",
"ICA",
"ENBL",
"EEQ",
"EEP",
"ENB",
"ECA",
"EXK",
"GI",
"ENH",
"ENH^B",
"ENH^C",
"NDRO",
"EGN",
"ENR",
"EPC",
"ETE",
"ETP",
"ERF",
"ENI",
"ENS",
"EGL",
"E",
"ENLK",
"ENLC",
"EBF",
"ENVA",
"NPO",
"ESV",
"ETM",
"EAA",
"EAB",
"EAE",
"ETR",
"ELA",
"ELB",
"ELJ",
"ELU",
"EFM",
"EMQ",
"EMZ",
"ENJ",
"EZT",
"EPD",
"EVC",
"ENV",
"EVHC",
"EVA",
"ENZ",
"EOG",
"EPE",
"EPAM",
"EPR",
"EPR^C",
"EPR^E",
"EPR^F",
"EQT",
"EQGP",
"EQM",
"EFX",
"EQC",
"EQC^D",
"EQC^E",
"EQCO",
"ELS",
"ELS^C",
"EQY",
"EQR",
"EQS",
"ERA",
"EROS",
"ESE",
"ESNT",
"ESS",
"ESS^H",
"EL",
"ESL",
"DEG",
"ETH",
"EURN",
"EEA",
"EVER",
"EVER^A",
"EVR",
"RE",
"EVRI",
"ES",
"EVTC",
"EVDY",
"EVGN",
"EVH",
"EXAM",
"EXAR",
"XCO",
"EXC",
"EXCU",
"EXPR",
"STAY",
"EXTN",
"EXR",
"XOM",
"FNB",
"FNB^E",
"FN",
"FDS",
"FICO",
"FMSA",
"FPI",
"FFG",
"FCB",
"AGM",
"AGM.A",
"AGM^A",
"AGM^B",
"AGM^C",
"FRT",
"FSS",
"FII",
"FPT",
"FMN",
"FDX",
"FCH",
"FCH^A",
"RACE",
"FGP",
"FOE",
"FCAM",
"FCAU",
"FBR",
"FGL",
"FNF",
"FNFV",
"FIS",
"FMO",
"FSCE",
"FAC",
"FAF",
"FBP",
"FCF",
"FDC",
"FHN",
"FHN^A",
"FR",
"AG",
"FMD",
"FNFG^B",
"FPO",
"FPO^A",
"FRC",
"FRC^A",
"FRC^B",
"FRC^C",
"FRC^D",
"FRC^E",
"FRC^F",
"FFA",
"FMY",
"FAV",
"FDEU",
"FIF",
"FSD",
"FPF",
"FEI",
"FPL",
"FCT",
"FGB",
"FHY",
"FEO",
"FAM",
"FE",
"FMER^A",
"FIT",
"OAKS",
"OAKS^A",
"FVE",
"FBC",
"DFP",
"PFD",
"PFO",
"FFC",
"FLC",
"FLT",
"FLTX",
"FTK",
"FLO",
"FLS",
"FLR",
"FLY",
"FMC",
"FTI",
"FMX",
"FL",
"F",
"FELP",
"FCE.A",
"FCE.B",
"FOR",
"FDI",
"FIG",
"FTAI",
"FSM",
"FBHS",
"FET",
"FCPT",
"FNV",
"FC",
"FSB",
"BEN",
"FT",
"FI",
"FCX",
"FMS",
"FDP",
"FRO",
"FSIC",
"FCN",
"FRM",
"FF",
"FXCM",
"GCV",
"GCV^B",
"GDV",
"GDV^A",
"GDV^D",
"GAB",
"GAB^D",
"GAB^G",
"GAB^H",
"GGZ",
"GGT",
"GGT^B",
"GUT",
"GUT^A",
"GFA",
"GCAP",
"GBL",
"GNT",
"GME",
"GPS",
"IT",
"GLOG",
"GLOG^A",
"GLOP",
"GMT",
"GZT",
"GNK",
"GNRT",
"GNRC",
"GAM",
"GAM^B",
"BGC",
"GD",
"GEH",
"GEK",
"GE",
"GEB",
"GGP",
"GGP^A",
"GIS",
"GM",
"GM.WS.A",
"GM.WS.B",
"GSI",
"GCO",
"GWR",
"GEL",
"GEN",
"GNE",
"GNE^A",
"G",
"GPC",
"GNW",
"GEO",
"GPRK",
"GPE^A",
"GGB",
"GTY",
"GIMO",
"GIL",
"GLT",
"GKOS",
"GSK",
"BRSS",
"GHI",
"GNL",
"GLP",
"GPN",
"GLPW",
"GSL",
"GSL^B",
"GLOB",
"GMED",
"GNC",
"GDDY",
"GOL",
"GFI",
"GG",
"GSBD",
"GS",
"GS^A",
"GS^B",
"GS^C",
"GS^D",
"GS^I",
"GS^J",
"GS^K",
"GSJ",
"TFG",
"GER",
"GMZ",
"GDP",
"GDP^C",
"GDP^D",
"GOV",
"GPX",
"GGG",
"GHM",
"GHC",
"GPT",
"GPT^A",
"GRAM",
"GVA",
"GRP.U",
"GPK",
"GTN",
"GTN.A",
"AJX",
"GXP",
"GXP^A",
"GXP^D",
"GXP^E",
"GWB",
"GB",
"GDOT",
"GBX",
"GHL",
"GEF",
"GEF.B",
"GFF",
"GPI",
"GRUB",
"PAC",
"ASR",
"AVAL",
"BSMX",
"TV",
"GTT",
"GSH",
"GES",
"GBAB",
"GGM",
"GPM",
"GGE",
"GEQ",
"GOF",
"GWRE",
"GUA",
"GLF",
"HRB",
"FUL",
"HAE",
"HK",
"HAL",
"HYH",
"HBI",
"HGR",
"HASI",
"HOG",
"HAR",
"HMY",
"HRS",
"HSC",
"HHS",
"HGH",
"HIG",
"HIG.WS",
"HNR",
"HTS",
"HTS^A",
"HVT",
"HVT.A",
"HE",
"HE^U",
"HCA",
"HCI",
"HCJ",
"HCP",
"HDB",
"HW",
"HNT",
"HR",
"HTA",
"HLS",
"HPY",
"HL",
"HL^B",
"HEI",
"HEI.A",
"HLX",
"HP",
"HLF",
"HTGC",
"HTGX",
"HTGY",
"HTGZ",
"HRTG",
"HT",
"HT^B",
"HT^C",
"HSY",
"HTZ",
"HES",
"HPE",
"HXL",
"HF",
"HGG",
"HCLP",
"ONE",
"HIW",
"HIL",
"HI",
"HRC",
"HTH",
"HLT",
"HNI",
"HMLP",
"HEP",
"HFC",
"HD",
"HMC",
"HON",
"HMN",
"HZN",
"HTF",
"HRL",
"HOS",
"HPT",
"HPT^D",
"HST",
"HLI",
"HSFC^B",
"HOV",
"HHC",
"HPQ",
"HRG",
"HSBC",
"HSBC^A",
"HSEA",
"HSEB",
"HUSI^F",
"HUSI^G",
"HUSI^H",
"HNP",
"HUBB",
"HUBS",
"HBM",
"HBM.WS",
"HPP",
"HGT",
"HUM",
"HII",
"HUN",
"H",
"HY",
"IAG",
"IBN",
"IDA",
"IEX",
"IDT",
"IHS",
"ITW",
"IMN",
"IMAX",
"IMPV",
"IMPR",
"IMS",
"ICD",
"IHC",
"IFN",
"IBA",
"BLOX",
"INFY",
"HIFR",
"IND",
"ING",
"INZ",
"ISF",
"ISG",
"ISP",
"IR",
"IM",
"INGR",
"IRC",
"IRC^A",
"IRC^B",
"IPHI",
"NSP",
"IBP",
"INST",
"I",
"I^A",
"ICE",
"IHG",
"IFF",
"IBM",
"IGT",
"IP",
"IOC",
"IPG",
"IPL^D",
"INXN",
"IL",
"SNOW",
"IPI",
"XON",
"IVC",
"INVN",
"VBF",
"VCV",
"VTA",
"VLT",
"IVR",
"IVR^B",
"IVR^A",
"OIA",
"VMO",
"VKQ",
"VPV",
"IVZ",
"IQI",
"VVR",
"VTN",
"VGM",
"IIM",
"ITG",
"IRET",
"IRET^",
"IRET^B",
"NVTA",
"IO",
"IRM",
"IRS",
"ICL",
"STAR",
"STAR^D",
"STAR^E",
"STAR^F",
"STAR^G",
"STAR^I",
"ITUB",
"ITC",
"ITT",
"ESI",
"IVH",
"JPM",
"JPM.WS",
"JPM^A",
"JPM^B",
"JPM^D",
"JPM^E",
"JPM^F",
"JPM^G",
"JPM^H",
"JAX",
"JCP",
"JGW",
"SJM",
"JBL",
"JEC",
"JHX",
"JNS",
"JOF",
"JAH",
"JMI",
"JCAP",
"JKS",
"JMP",
"JMPB",
"JMPC",
"JBT",
"BTO",
"HEQ",
"JHS",
"JHI",
"HPF",
"HPI",
"HPS",
"PDT",
"HTD",
"HTY",
"JW.A",
"JW.B",
"JNJ",
"JCI",
"JONE",
"JLL",
"JMG",
"JOY",
"JPEP",
"JFC",
"JMEI",
"JNPR",
"JP",
"JE",
"LRN",
"KAI",
"KAMN",
"KSU",
"KSU^",
"KS",
"KAR",
"KATE",
"KED",
"KYE",
"KMF",
"KYN",
"KYN^E",
"KYN^F",
"KYN^G",
"KB",
"KBH",
"KBR",
"KAP",
"KCG",
"K",
"KEM",
"KMPA",
"KMPR",
"KMT",
"KW",
"KWN",
"KEN",
"KEG",
"KEY",
"KEY^G",
"KEYS",
"KRC",
"KRC^G",
"KRC^H",
"KMB",
"KIM",
"KIM^I",
"KIM^J",
"KIM^K",
"KMI",
"KMI.WS",
"KMI^A",
"KND",
"KING",
"KFS",
"KGC",
"KEX",
"KRG",
"KKR",
"KFH",
"KFI",
"KFN^",
"KIO",
"KMG",
"KNX",
"KNL",
"KNOP",
"KN",
"KSS",
"PHG",
"KOP",
"KEP",
"KEF",
"KF",
"KFY",
"KOS",
"KRA",
"KKD",
"KR",
"KRO",
"KT",
"KYO",
"LB",
"SCX",
"LLL",
"LQ",
"LH",
"LG",
"LADR",
"LDR",
"LCI",
"LPI",
"LVS",
"LHO",
"LHO^H",
"LHO^I",
"LFL",
"LDF",
"LGI",
"LAZ",
"LOR",
"LZB",
"LF",
"LEA",
"LEE",
"BWG",
"LM",
"LEG",
"CVB",
"JBK",
"KCC",
"KTH",
"KTN",
"KTP",
"XKE",
"LDOS",
"LEJU",
"LC",
"LEN",
"LEN.B",
"LII",
"LUK",
"LVLT",
"LXP",
"LXP^C",
"LXK",
"LPL",
"USA",
"ASG",
"LPT",
"LOCK",
"LITB",
"LNC",
"LNC.WS",
"LNN",
"LNKD",
"LGF",
"LAD",
"LYV",
"LYG",
"SCD",
"TLI",
"RIT",
"LMT",
"L",
"LPX",
"LOW",
"LXU",
"LTC",
"LUB",
"LL",
"LXFR",
"LXFT",
"LUX",
"LDL",
"WLH",
"LYB",
"MTB",
"MTB.WS",
"MTB^",
"MTB^C",
"MDC",
"MHO",
"MHO^A",
"MAC",
"CLI",
"MGU",
"MIC",
"MFD",
"BMA",
"M",
"MCN",
"MSP",
"MMP",
"MGA",
"MX",
"MH^A",
"MH^C",
"MHNA",
"MHNB",
"MHNC",
"MAIN",
"MSCA",
"MMD",
"MNK",
"MZF",
"HYF",
"MANU",
"MTW",
"MN",
"MAN",
"MFC",
"MRO",
"MPC",
"MMI",
"MCS",
"MRIN",
"MHG",
"MPX",
"HZO",
"MKL",
"VAC",
"MMC",
"MLM",
"MAS",
"DOOR",
"MTZ",
"MA",
"MTDR",
"MTRN",
"MATX",
"MLP",
"MMS",
"MXL",
"MXPT",
"MBI",
"MNI",
"MKC",
"MKC.V",
"MDR",
"MCD",
"MUX",
"MHFI",
"MCK",
"MDU",
"MJN",
"MTL",
"MTL^",
"MEG",
"MPW",
"MED",
"MCC",
"MCQ",
"MCV",
"MCX",
"MDLY",
"MD",
"MDT",
"MW",
"MRK",
"MCY",
"MDP",
"MTH",
"MTOR",
"MER^D.CL",
"MER^E.CL",
"MER^F.CL",
"MER^K",
"MER^M",
"MER^P",
"PIY",
"MTR",
"MSB",
"MPG",
"MEI",
"MET",
"MET^A",
"MTD",
"MXE",
"MXF",
"MFA",
"MFA^B",
"MFO",
"MIL",
"MCR",
"MGF",
"MIN",
"MMT",
"MFM",
"MFV",
"MTG",
"MGM",
"KORS",
"MAA",
"MEP",
"MSL",
"MPO",
"MCRN",
"MLR",
"HIE",
"MR",
"MTX",
"MP^D",
"MG",
"MTU",
"MIXT",
"MFG",
"MBT",
"MBLY",
"MODN",
"MOD",
"MC",
"MHK",
"MOH",
"TAP",
"TAP.A",
"MNR",
"MNR^A",
"MNR^B",
"MORE",
"MON",
"MWW",
"MCO",
"MOG.A",
"MOG.B",
"MS",
"MS^A",
"MS^E",
"MS^F",
"MS^G",
"MS^I",
"MSK",
"MWG",
"MWO",
"MWR",
"APF",
"CAF",
"MSD",
"EDD",
"MSF",
"IIF",
"MOS",
"MSI",
"MOV",
"MPLX",
"MRC",
"ICB",
"HJV",
"MSA",
"MSM",
"MSCI",
"MSG",
"MSGN",
"MLI",
"MWA",
"MPSX",
"MUR",
"MUSA",
"MVO",
"MVC",
"MVCB",
"MYE",
"NBR",
"NC",
"NTP",
"NBHC",
"NFG",
"NGG",
"NHI",
"NOV",
"NPK",
"NNN",
"NNN^D",
"NNN^E",
"SID",
"NSA",
"NSM",
"NW^C",
"NGS",
"NGVC",
"NRP",
"NTZ",
"NLS",
"NCI",
"NVGS",
"NNA",
"NM",
"NM^G",
"NM^H",
"NAP",
"NMM",
"NAV",
"NAV^D",
"NCS",
"NCR",
"NP",
"NEFF",
"NNI",
"NPTN",
"N",
"NSR",
"NVRO",
"HYB",
"GF",
"NWHM",
"IRL",
"NEWM",
"NMFC",
"EDU",
"NEWR",
"NRZ",
"SNR",
"NWY",
"NYCB",
"NYCB^U",
"NYRT",
"NYT",
"NCT",
"NCT^B",
"NCT^C",
"NCT^D",
"NWL",
"NFX",
"NJR",
"NEU",
"NEM",
"NR",
"NHF",
"NXRT",
"NEP",
"NEE",
"NEE^C",
"NEE^G",
"NEE^H",
"NEE^I",
"NEE^J",
"NEE^P",
"NEE^Q",
"NGL",
"NMK^B",
"NMK^C",
"NJ",
"NLSN",
"NKE",
"NMBL",
"NTT",
"NKA",
"NI",
"NL",
"NOAH",
"NE",
"NBL",
"NOK",
"NOK$",
"NMR",
"NORD",
"NAO",
"NAT",
"JWN",
"NSC",
"NTL",
"NOA",
"NADL",
"NRT",
"NTI",
"NOC",
"NSAM",
"NRE",
"NRF",
"NRF^A",
"NRF^B",
"NRF^C",
"NRF^D",
"NRF^E",
"NWN",
"NWE",
"NVS",
"NVO",
"DNOW",
"NQ",
"NRG",
"NYLD",
"NYLD.A",
"DCM",
"NUS",
"NUE",
"NS",
"NSH",
"NSS",
"JMLP",
"NEA",
"NUV",
"NUW",
"NAZ",
"NBB",
"NBD",
"NKX",
"NAC",
"NCA",
"NTC",
"JCE",
"JQC",
"JDD",
"NAD",
"DIAX",
"JMF",
"NEV",
"JPW",
"JFR",
"JRO",
"NKG",
"JGV",
"JGH",
"JHA",
"JHY",
"NXC",
"NXN",
"NID",
"NQM",
"NMY",
"NMT",
"NUM",
"NMS",
"JLS",
"JMM",
"NMA",
"NMI",
"NMO",
"NIO",
"NXJ",
"NRK",
"NAN",
"NNY",
"NNC",
"NUO",
"NQP",
"NPP",
"JPI",
"JPC",
"NPF",
"NPM",
"NPT",
"NPI",
"NQU",
"NQI",
"JTP",
"JPS",
"JHP",
"JRI",
"BXMX",
"SPXX",
"NIM",
"NQS",
"NXP",
"NXQ",
"NXR",
"NSL",
"JSD",
"JTD",
"JTA",
"NTX",
"NPV",
"NIQ",
"JMT",
"NES",
"NVR",
"OAK",
"OAS",
"OXY",
"OII",
"OZM",
"OCIP",
"OCN",
"OFG",
"OFG^A",
"OFG^B",
"OFG^D",
"OGE",
"OIBR",
"OIBR.C",
"OIS",
"ODC",
"ORI",
"OLN",
"OMAM",
"OHI",
"OME",
"OMC",
"OMN",
"ASGN",
"ONDK",
"OGS",
"OLP",
"OB",
"OMF",
"OKS",
"OKE",
"OOMA",
"OPK",
"OPWR",
"OPY",
"ORCL",
"ORAN",
"OA",
"ORC",
"OEC",
"ORN",
"IX",
"ORA",
"OSK",
"OUT",
"OMI",
"OC",
"OI",
"OXM",
"PAI",
"ROYT",
"PACD",
"PCG",
"PKG",
"PANW",
"PAM",
"P",
"PHX",
"PAR",
"PGRE",
"PKE",
"PKD",
"PH",
"PKY",
"PE",
"PRE",
"PRE^D",
"PRE^E",
"PRE^F",
"PRTY",
"PN",
"PAYC",
"PBF",
"PBFX",
"BTU",
"PSO",
"PEB",
"PEB^A",
"PEB^B",
"PEB^C",
"PBA",
"PGH",
"PVA",
"PWE",
"PNTA",
"PEI",
"PEI^A",
"PEI^B",
"PFSI",
"PMT",
"PAG",
"PNR",
"PEN",
"PBY",
"POM",
"PEP",
"PFGC",
"PSG",
"PKI",
"PBT",
"PRGO",
"PZE",
"PTR",
"PBR",
"PBR.A",
"PQ",
"PFE",
"PMC",
"PHH",
"PM",
"PHI",
"PSX",
"PSXP",
"PFX",
"PNX",
"FENG",
"DOC",
"PNY",
"PDM",
"PIR",
"PCQ",
"PCK",
"PZC",
"PCM",
"PTY",
"PCN",
"PCI",
"PDI",
"PGP",
"PHK",
"PKO",
"PFL",
"PFN",
"PMF",
"PML",
"PMX",
"PNF",
"PNI",
"PYN",
"RCS",
"PF",
"PNW",
"PES",
"PHD",
"PHT",
"MAV",
"MHI",
"PXD",
"PJC",
"PBI",
"PBI^B",
"PJT",
"PAA",
"PAGP",
"PLNT",
"PLT",
"PAH",
"PCL",
"PGEM",
"PNC",
"PNC.WS",
"PNC^P",
"PNC^Q",
"PNM",
"PII",
"POL",
"POR",
"PKX",
"POST",
"PPS",
"PPS^A",
"POT",
"POWR",
"PPG",
"PPX",
"PPL",
"PYS",
"PYT",
"PX",
"PCP",
"PDS",
"APTS",
"PJS",
"PGND",
"PBH",
"PVG",
"PRI",
"PPP",
"PFG",
"PGZ",
"PVTD",
"PRA",
"PG",
"PGR",
"BIN",
"PLD",
"PRO",
"PBB",
"PB",
"PL^C",
"PL^E",
"PRLB",
"PSTG",
"PFS",
"PFK",
"PJH",
"PRH",
"PRU",
"GHY",
"PUK",
"PUK^",
"PUK^A",
"ISD",
"PSB",
"PSB^S",
"PSB^T",
"PSB^U",
"PSB^V",
"TLK",
"PEG",
"PSA",
"PSA^A",
"PSA^Q",
"PSA^R",
"PSA^S",
"PSA^T",
"PSA^U",
"PSA^V",
"PSA^W",
"PSA^X",
"PSA^Y",
"PSA^Z",
"PHM",
"PBYI",
"PCF",
"PMM",
"PIM",
"PMO",
"PPT",
"PVH",
"PZN",
"QTWO",
"QEP",
"QIHU",
"QTS",
"QUAD",
"KWR",
"NX",
"PWR",
"QTM",
"DGX",
"STR",
"Q",
"QUOT",
"CTQ",
"CTU",
"CTV",
"CTW",
"CTX",
"CTY",
"CTZ",
"RAX",
"RDN",
"RAS",
"RAS^A",
"RAS^B",
"RAS^C",
"RFT",
"RFTA",
"RL",
"RPT",
"RPT^D",
"RRC",
"RJD",
"RJF",
"RYAM",
"RYN",
"RTN",
"RCAP",
"RMAX",
"RLD",
"RLGY",
"O",
"O^F",
"RHT",
"RLH",
"RWT",
"RBC",
"RGC",
"REG",
"REG^F",
"REG^G",
"RM",
"RF",
"RF^A",
"RF^B",
"RGS",
"RGA",
"RZA",
"RS",
"RENX",
"RELX",
"RNR",
"RNR^C",
"RNR^E",
"SOL",
"RENN",
"RNF",
"RSG",
"RMD",
"REN",
"RFP",
"RSO",
"RSO^A",
"RSO^B",
"RSO^C",
"QSR",
"RH",
"RPAI",
"RPAI^A",
"REV",
"REX",
"REXR",
"RXN",
"RAI",
"RICE",
"RMP",
"RNG",
"RIO",
"RBA",
"RAD",
"RIV",
"RLI",
"RLJ",
"RRTS",
"RHI",
"ROK",
"COL",
"RCI",
"ROG",
"ROL",
"ROP",
"RRMS",
"RST",
"RSE",
"RDC",
"RY",
"RY^S",
"RY^T",
"RBS",
"RBS^E",
"RBS^F",
"RBS^G",
"RBS^H",
"RBS^I",
"RBS^L",
"RBS^R",
"RBS^S",
"RBS^T",
"RCL",
"RDS.A",
"RDS.B",
"RGT",
"RMT",
"RVT",
"RES",
"RPM",
"RSPP",
"RT",
"RKUS",
"RTEC",
"R",
"RYI",
"RHP",
"SBR",
"SB",
"SB^B",
"SB^C",
"SB^D",
"SFE",
"CRM",
"SMM",
"SBH",
"SJT",
"SN",
"SD",
"SDT",
"SDR",
"PER",
"SNY",
"SC",
"SOV^C",
"SAP",
"SAQ",
"SAR",
"SSL",
"BFS",
"BFS^C",
"SCG",
"SLB",
"SWM",
"SAIC",
"SALT",
"SLTB",
"SBNA",
"SBNB",
"STNG",
"SMG",
"SNI",
"LBF",
"KHI",
"KMM",
"KTF",
"KST",
"KSM",
"SA",
"CKH",
"SDRL",
"SDLP",
"SEE",
"SSW",
"SSW^C",
"SSW^D",
"SSW^E",
"SSWN",
"SEAS",
"JBN",
"JBR",
"SIR",
"SEM",
"SGZA",
"SEMG",
"SMI",
"SRE",
"SNH",
"SNHN",
"ST",
"SXT",
"SQNS",
"SRG",
"SCI",
"SERV",
"NOW",
"SSE",
"SHAK",
"SJR",
"SHLX",
"SHW",
"SHG",
"SFL",
"SHOP",
"SSTK",
"SBGL",
"SIG",
"SBY",
"SSNI",
"SLW",
"SPG",
"SPG^J",
"SSD",
"SHI",
"SIX",
"SJW",
"SKM",
"SKX",
"SLG",
"SLG^I",
"SM",
"SFS",
"SNN",
"AOS",
"SNA",
"SQM",
"SLRA",
"SWI",
"SLH",
"SAH",
"SON",
"SNE",
"BID",
"SFUN",
"SOR",
"SJI",
"SXE",
"SCE^F",
"SCE^G",
"SCE^H",
"SCE^J",
"SO",
"SOJA",
"SCCO",
"LUV",
"SWX",
"SWN",
"SWNC",
"SSS",
"SPA",
"SPE",
"SE",
"SEP",
"SPB",
"TRK",
"SPR",
"SRC",
"SRLP",
"S",
"SPXC",
"FLOW",
"SQ",
"JOE",
"STJ",
"STAG",
"STAG^A",
"STAG^B",
"SSI",
"SFG",
"SMP",
"SXI",
"SWH",
"SWJ",
"SWK",
"STN",
"SGU",
"SRT",
"HOT",
"STWD",
"SWAY",
"STT",
"STT^C",
"STT^D",
"STT^E",
"STO",
"SPLP",
"SCS",
"SCM",
"SCQ",
"SCL",
"STE",
"STL",
"STC",
"SF",
"SFN",
"SWC",
"STM",
"SGY",
"EDF",
"EDI",
"SGM",
"STON",
"SRI",
"STOR",
"SGL",
"SYK",
"RGR",
"SPH",
"SCNB",
"SMFG",
"INN",
"INN^A",
"INN^B",
"INN^C",
"SUM",
"SMLP",
"SUI",
"SUI^A",
"SLF",
"SXCP",
"SXC",
"SU",
"SUNE",
"SXL",
"SUN",
"SHO",
"SHO^D",
"STI",
"STI.WS.A",
"STI.WS.B",
"STI^A",
"STI^E",
"SPN",
"SUP",
"SVU",
"SWFT",
"SWZ",
"SYA",
"SYF",
"SYT",
"SNX",
"SNV",
"SNV^C",
"GJH",
"GJO",
"GJS",
"GJP",
"GJR",
"GJT",
"GJV",
"SYY",
"SYX",
"DATA",
"TAHO",
"TWN",
"TSM",
"XRS",
"TAL",
"TLN",
"TEGP",
"TEP",
"SKT",
"TAOM",
"NGLS",
"NGLS^A",
"TRGP",
"TGT",
"TARO",
"TTM",
"TCO",
"TCO^J",
"TCO^K",
"TMHC",
"TCP",
"TCB",
"TCB.WS",
"TCB^B",
"TCB^C",
"TCPI",
"TSI",
"TEL",
"TMH",
"TISI",
"TCK",
"TE",
"TK",
"TGP",
"TOO",
"TOO^A",
"TOO^B",
"TNK",
"GCI",
"TGNA",
"TRC",
"HQH",
"THQ",
"HQL",
"THW",
"TDOC",
"TEO",
"TI",
"TI.A",
"TDY",
"TFX",
"VIV",
"TEF",
"TDA",
"TDE",
"TDI",
"TDJ",
"TDS",
"TU",
"TDF",
"EMF",
"TEI",
"GIM",
"TPX",
"TS",
"THC",
"TNC",
"TEN",
"TVC",
"TVE",
"TDC",
"TER",
"TEX",
"TX",
"TNH",
"TRNO",
"TRNO^A",
"TSO",
"TLLP",
"TTI",
"TEVA",
"TPL",
"TGH",
"TXT",
"TXTR",
"TTF",
"AES",
"AES^C",
"BX",
"SCHW",
"SCHW^B",
"SCHW^C",
"SRV",
"GRX",
"GRX^A",
"GRX^B",
"GDL",
"GDL^B",
"THG",
"THGA",
"RUBI",
"TRV",
"TMO",
"THR",
"TPRE",
"TSLF",
"TCRX",
"TCRZ",
"TC",
"TRI",
"THO",
"TDW",
"TIER",
"TIF",
"TLYS",
"TSU",
"TIME",
"TWC",
"TWX",
"TKR",
"TMST",
"TWI",
"TJX",
"TOL",
"TR",
"BLD",
"TMK",
"TMK^B",
"TTC",
"TD",
"NDP",
"TYG",
"TYG^B",
"TYG^C.CL",
"NTG",
"TTP",
"TPZ",
"TSS",
"TOT",
"TOWR",
"TSQ",
"TM",
"TSLX",
"TAC",
"TRP",
"TCI",
"TDG",
"TLP",
"RIG",
"RIGP",
"TGS",
"TRU",
"TA",
"TANN",
"TANO",
"TANP",
"TVPT",
"TRR",
"TREC",
"TG",
"THS",
"TRMR",
"TREX",
"TY",
"TY^",
"TPH",
"TCAP",
"TCCA",
"TCCB",
"TRCO",
"TPUB",
"TSL",
"TNET",
"TRN",
"TSE",
"TPVG",
"TPVZ",
"GTS",
"TGI",
"TROX",
"TBI",
"TRUP",
"TNP",
"TNP^B",
"TNP^C",
"TNP^D",
"TUMI",
"TUP",
"TKC",
"TKF",
"TRQ",
"TPC",
"TWTR",
"TWO",
"TYC",
"TYL",
"TSN",
"TSNU",
"USB",
"USB^A",
"USB^H",
"USB^M",
"USB^N",
"USB^O",
"USPH",
"SLCA",
"UBS",
"UBS^D",
"UCP",
"UGI",
"UPL",
"UGP",
"UMH",
"UMH^A",
"UMH^B",
"UA",
"UFI",
"UNF",
"UN",
"UL",
"UNP",
"UIS",
"UNT",
"UAL",
"UDR",
"UMC",
"UPS",
"URI",
"USM",
"UZA",
"UZB",
"UZC",
"X",
"UTX",
"UNH",
"UTL",
"UNVR",
"UAM",
"UVV",
"UHT",
"UHS",
"UVE",
"UTI",
"UNM",
"UE",
"UBA",
"UBP",
"UBP^F",
"UBP^G",
"USAC",
"USNA",
"USDP",
"USG",
"BIF",
"VFC",
"EGY",
"MTN",
"VALE",
"VALE.P",
"VRX",
"VLO",
"VLP",
"VHI",
"VR",
"VLY",
"VLY.WS",
"VLY^A",
"VMI",
"VAL",
"VNTV",
"VAR",
"VGR",
"VVC",
"VEC",
"VEDL",
"VEEV",
"VTRB",
"VTR",
"VER",
"VER^F",
"PAY",
"VRTV",
"VZ",
"VZA",
"VET",
"VVI",
"VCO",
"VNCE",
"VMEM",
"VIPS",
"VGI",
"DCA",
"V",
"VSH",
"VPG",
"VSTO",
"VC",
"VSI",
"VSLR",
"VMW",
"VOC",
"VCRA",
"VG",
"VNO",
"VNO^G",
"VNO^I",
"VNO^J",
"VNO^K",
"VNO^L",
"VJET",
"IAE",
"IHD",
"VOYA",
"IGA",
"IGD",
"IDE",
"IID",
"IRR",
"PPR",
"VTTI",
"VMC",
"WTI",
"WPC",
"WRB",
"WRB^B",
"GRA",
"GWW",
"WNC",
"WBC",
"WDR",
"WAGE",
"WD",
"WMT",
"DIS",
"WAC",
"WRE",
"WCN",
"WM",
"WAT",
"WSO",
"WSO.B",
"WTS",
"WPP",
"W",
"WCIC",
"WFT",
"WBS",
"WBS.WS",
"WBS^E",
"WEC",
"WTW",
"WRI",
"WMK",
"WCG",
"WFC",
"WFC.WS",
"WFC^J",
"WFC^L",
"WFC^N",
"WFC^O",
"WFC^P",
"WFC^Q",
"WFC^R",
"WFC^T",
"WFC^V",
"WFE^A",
"EOD",
"HCN",
"HCN^I",
"HCN^J",
"WAIR",
"WCC",
"WST",
"WR",
"WAL",
"WEA",
"ESD",
"EMD",
"GDO",
"EHI",
"GDF",
"HIX",
"HIO",
"HYI",
"IGI",
"MHY",
"MMU",
"WMC",
"DMO",
"MTT",
"MHF",
"MNP",
"GFY",
"SBW",
"WIW",
"WIA",
"WGP",
"WES",
"WNRL",
"WNR",
"WU",
"WAB",
"WLK",
"WLKP",
"WMLP",
"WBK",
"WRK",
"WHG",
"WEX",
"WY",
"WY^A",
"WGL",
"WHR",
"WTM",
"WSR",
"WWAV",
"WLL",
"WHZ",
"WG",
"WMB",
"WPZ",
"WSM",
"WSH",
"WGO",
"FUR",
"WIT",
"WNS",
"WWW",
"WF",
"WDAY",
"WK",
"INT",
"WPT",
"WWE",
"WOR",
"WPG",
"WPG^H",
"WPG^I",
"WPX",
"WPXP",
"WYN",
"XTLY",
"XEL",
"XHR",
"XRM",
"XRX",
"XIN",
"XL",
"XOXO",
"XPO",
"XUE",
"XYL",
"YDKN",
"AUY",
"YZC",
"YELP",
"YGE",
"YRD",
"YOKU",
"YPF",
"YUM",
"YUME",
"ZFC",
"ZAYO",
"ZEN",
"ZPIN",
"ZBH",
"ZB^A",
"ZB^F",
"ZB^G",
"ZB^H",
"ZBK",
"ZOES",
"ZTS",
"ZF",
"ZTR"};
	}
}