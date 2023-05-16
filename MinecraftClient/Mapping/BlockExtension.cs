using MinecraftClient.Protocol.Handlers;

namespace MinecraftClient.Mapping;

public static class BlockExtension
{
    public static bool IsTopSlab(this Block block, int protocolVersion)
    {
        if (protocolVersion >= Protocol18Handler.MC_1_19_4_Version)
        {
            switch (block.BlockId)
            {
                case 11018: // OakSlab
                case 11024: // SpruceSlab
                case 11030: // BirchSlab
                case 11036: // JungleSlab
                case 11042: // AcaciaSlab
                case 11054: // DarkOakSlab
                case 11060: // MangroveSlab
                case 18510: // CrimsonSlab
                case 18516: // WarpedSlab
                case 11078: // StoneSlab
                case 11108: // CobblestoneSlab
                case 13948: // MossyCobblestoneSlab
                case 11084: // SmoothStoneSlab
                case 11120: // StoneBrickSlab
                case 13936: // MossyStoneBrickSlab
                case 13972: // GraniteSlab
                case 13924: // PolishedGraniteSlab
                case 13996: // DioriteSlab
                case 13942: // PolishedDioriteSlab
                case 13978: // AndesiteSlab
                case 13990: // PolishedAndesiteSlab
                case 22132: // CobbledDeepslateSlab
                case 22543: // PolishedDeepslateSlab
                case 23365: // DeepslateBrickSlab
                case 22954: // DeepslateTileSlab
                case 11114: // BrickSlab
                case 11126: // MudBrickSlab
                case 11090: // SandstoneSlab
                case 13960: // SmoothSandstoneSlab
                case 11096: // CutSandstoneSlab
                case 11144: // RedSandstoneSlab
                case 13930: // SmoothRedSandstoneSlab
                case 11150: // CutRedSandstoneSlab
                case 10562: // PrismarineSlab
                case 10568: // PrismarineBrickSlab
                case 10574: // DarkPrismarineSlab
                case 11132: // NetherBrickSlab
                case 13984: // RedNetherBrickSlab
                case 19707: // BlackstoneSlab
                case 20208: // PolishedBlackstoneSlab
                case 19717: // PolishedBlackstoneBrickSlab
                case 13954: // EndStoneBrickSlab
                case 11156: // PurpurSlab
                case 11138: // QuartzSlab
                case 13966: // SmoothQuartzSlab
                case 21510: // CutCopperSlab
                case 21504: // ExposedCutCopperSlab
                case 21498: // WeatheredCutCopperSlab
                case 21492: // OxidizedCutCopperSlab
                case 21862: // WaxedCutCopperSlab
                case 21856: // WaxedExposedCutCopperSlab
                case 21850: // WaxedWeatheredCutCopperSlab
                case 21844: // WaxedOxidizedCutCopperSlab
                    return true;
            }
        }
        else if (protocolVersion == Protocol18Handler.MC_1_13_Version)
        {
            switch (block.BlockId)
            {
                case 19257: // CutCopperSlab
                case 19251: // ExposedCutCopperSlab
                case 19245: // WeatheredCutCopperSlab
                case 19239: // OxidizedCutCopperSlab
                case 19609: // WaxedCutCopperSlab
                case 19603: // WaxedExposedCutCopperSlab
                case 19597: // WaxedWeatheredCutCopperSlab
                case 19591: // WaxedOxidizedCutCopperSlab
                case 9042: // OakSlab
                case 9048: // SpruceSlab
                case 9054: // BirchSlab
                case 9060: // JungleSlab
                case 9066: // AcaciaSlab
                case 9072: // DarkOakSlab
                case 9078: // MangroveSlab
                case 16257: // CrimsonSlab
                case 16263: // WarpedSlab
                case 9084: // StoneSlab
                case 9090: // SmoothStoneSlab
                case 9096: // SandstoneSlab
                case 9102: // CutSandstoneSlab
                case 9108: // PetrifiedOakSlab
                case 9114: // CobblestoneSlab
                case 9120: // BrickSlab
                case 9126: // StoneBrickSlab
                case 9132: // MudBrickSlab
                case 9138: // NetherBrickSlab
                case 9144: // QuartzSlab
                case 9150: // RedSandstoneSlab
                case 9156: // CutRedSandstoneSlab
                case 9162: // PurpurSlab
                case 8586: // PrismarineSlab
                case 8592: // PrismarineBrickSlab
                case 8598: // DarkPrismarineSlab
                case 11671: // PolishedGraniteSlab
                case 11677: // SmoothRedSandstoneSlab
                case 11683: // MossyStoneBrickSlab
                case 11689: // PolishedDioriteSlab
                case 11695: // MossyCobblestoneSlab
                case 11701: // EndStoneBrickSlab
                case 11707: // SmoothSandstoneSlab
                case 11713: // SmoothQuartzSlab
                case 11719: // GraniteSlab
                case 11725: // AndesiteSlab
                case 11731: // RedNetherBrickSlab
                case 11737: // PolishedAndesiteSlab
                case 11743: // DioriteSlab
                case 19863: // CobbledDeepslateSlab
                case 20274: // PolishedDeepslateSlab
                case 21096: // DeepslateBrickSlab
                case 20685: // DeepslateTileSlab
                case 17454: // BlackstoneSlab
                case 17955: // PolishedBlackstoneSlab
                case 17464: // PolishedBlackstoneBrickSlab
                    return true;
            }
        }
        else if (protocolVersion >= Protocol18Handler.MC_1_19_Version)
        {
            switch (block.BlockId)
            {
                case 19257: // CutCopperSlab
                case 19251: // ExposedCutCopperSlab
                case 19245: // WeatheredCutCopperSlab
                case 19239: // OxidizedCutCopperSlab
                case 19609: // WaxedCutCopperSlab
                case 19603: // WaxedExposedCutCopperSlab
                case 19597: // WaxedWeatheredCutCopperSlab
                case 19591: // WaxedOxidizedCutCopperSlab
                case 9042: // OakSlab
                case 9048: // SpruceSlab
                case 9054: // BirchSlab
                case 9060: // JungleSlab
                case 9066: // AcaciaSlab
                case 9072: // DarkOakSlab
                case 9078: // MangroveSlab
                case 16257: // CrimsonSlab
                case 16263: // WarpedSlab
                case 9084: // StoneSlab
                case 9090: // SmoothStoneSlab
                case 9096: // SandstoneSlab
                case 9102: // CutSandstoneSlab
                case 9108: // PetrifiedOakSlab
                case 9114: // CobblestoneSlab
                case 9120: // BrickSlab
                case 9126: // StoneBrickSlab
                case 9132: // MudBrickSlab
                case 9138: // NetherBrickSlab
                case 9144: // QuartzSlab
                case 9150: // RedSandstoneSlab
                case 9156: // CutRedSandstoneSlab
                case 9162: // PurpurSlab
                case 8586: // PrismarineSlab
                case 8592: // PrismarineBrickSlab
                case 8598: // DarkPrismarineSlab
                case 11671: // PolishedGraniteSlab
                case 11677: // SmoothRedSandstoneSlab
                case 11683: // MossyStoneBrickSlab
                case 11689: // PolishedDioriteSlab
                case 11695: // MossyCobblestoneSlab
                case 11701: // EndStoneBrickSlab
                case 11707: // SmoothSandstoneSlab
                case 11713: // SmoothQuartzSlab
                case 11719: // GraniteSlab
                case 11725: // AndesiteSlab
                case 11731: // RedNetherBrickSlab
                case 11737: // PolishedAndesiteSlab
                case 11743: // DioriteSlab
                case 19863: // CobbledDeepslateSlab
                case 20274: // PolishedDeepslateSlab
                case 21096: // DeepslateBrickSlab
                case 20685: // DeepslateTileSlab
                case 17454: // BlackstoneSlab
                case 17955: // PolishedBlackstoneSlab
                case 17464: // PolishedBlackstoneBrickSlab
                    return true;
            }
        }
        else if (protocolVersion >= Protocol18Handler.MC_1_17_Version)
        {
            switch (block.BlockId)
            {
                case 18163: // CutCopperSlab
                case 18157: // ExposedCutCopperSlab
                case 18151: // WeatheredCutCopperSlab
                case 18145: // OxidizedCutCopperSlab
                case 18515: // WaxedCutCopperSlab
                case 18509: // WaxedExposedCutCopperSlab
                case 18503: // WaxedWeatheredCutCopperSlab
                case 18497: // WaxedOxidizedCutCopperSlab
                case 8551: // OakSlab
                case 8557: // SpruceSlab
                case 8563: // BirchSlab
                case 8569: // JungleSlab
                case 8575: // AcaciaSlab
                case 8581: // DarkOakSlab
                case 15302: // CrimsonSlab
                case 15308: // WarpedSlab
                case 8587: // StoneSlab
                case 8593: // SmoothStoneSlab
                case 8599: // SandstoneSlab
                case 8605: // CutSandstoneSlab
                case 8611: // PetrifiedOakSlab
                case 8617: // CobblestoneSlab
                case 8623: // BrickSlab
                case 8629: // StoneBrickSlab
                case 8635: // NetherBrickSlab
                case 8641: // QuartzSlab
                case 8647: // RedSandstoneSlab
                case 8653: // CutRedSandstoneSlab
                case 8659: // PurpurSlab
                case 8095: // PrismarineSlab
                case 8101: // PrismarineBrickSlab
                case 8107: // DarkPrismarineSlab
                case 11040: // PolishedGraniteSlab
                case 11046: // SmoothRedSandstoneSlab
                case 11052: // MossyStoneBrickSlab
                case 11058: // PolishedDioriteSlab
                case 11064: // MossyCobblestoneSlab
                case 11070: // EndStoneBrickSlab
                case 11076: // SmoothSandstoneSlab
                case 11082: // SmoothQuartzSlab
                case 11088: // GraniteSlab
                case 11094: // AndesiteSlab
                case 11100: // RedNetherBrickSlab
                case 11106: // PolishedAndesiteSlab
                case 11112: // DioriteSlab
                case 18768: // CobbledDeepslateSlab
                case 19179: // PolishedDeepslateSlab
                case 20001: // DeepslateBrickSlab
                case 19590: // DeepslateTileSlab
                case 16499: // BlackstoneSlab
                case 17000: // PolishedBlackstoneSlab
                case 16509: // PolishedBlackstoneBrickSlab
                    return true;
            }
        }
        else if (protocolVersion >= Protocol18Handler.MC_1_16_Version)
        {
            switch (block.BlockId)
            {
                case 8305: // OakSlab
                case 8311: // SpruceSlab
                case 8317: // BirchSlab
                case 8323: // JungleSlab
                case 8329: // AcaciaSlab
                case 8335: // DarkOakSlab
                case 15056: // CrimsonSlab
                case 15062: // WarpedSlab
                case 8341: // StoneSlab
                case 8347: // SmoothStoneSlab
                case 8353: // SandstoneSlab
                case 8359: // CutSandstoneSlab
                case 8365: // PetrifiedOakSlab
                case 8371: // CobblestoneSlab
                case 8377: // BrickSlab
                case 8383: // StoneBrickSlab
                case 8389: // NetherBrickSlab
                case 8395: // QuartzSlab
                case 8401: // RedSandstoneSlab
                case 8407: // CutRedSandstoneSlab
                case 8413: // PurpurSlab
                case 7849: // PrismarineSlab
                case 7855: // PrismarineBrickSlab
                case 7861: // DarkPrismarineSlab
                case 10794: // PolishedGraniteSlab
                case 10800: // SmoothRedSandstoneSlab
                case 10806: // MossyStoneBrickSlab
                case 10812: // PolishedDioriteSlab
                case 10818: // MossyCobblestoneSlab
                case 10824: // EndStoneBrickSlab
                case 10830: // SmoothSandstoneSlab
                case 10836: // SmoothQuartzSlab
                case 10842: // GraniteSlab
                case 10848: // AndesiteSlab
                case 10854: // RedNetherBrickSlab
                case 10860: // PolishedAndesiteSlab
                case 10866: // DioriteSlab
                case 16253: // BlackstoneSlab
                case 16754: // PolishedBlackstoneSlab
                case 16263: // PolishedBlackstoneBrickSlab
                    return true;
            }
        }
        else if (protocolVersion >= Protocol18Handler.MC_1_15_Version)
        {
            switch (block.BlockId)
            {
                case 7765: // OakSlab
                case 7771: // SpruceSlab
                case 7777: // BirchSlab
                case 7783: // JungleSlab
                case 7789: // AcaciaSlab
                case 7795: // DarkOakSlab
                case 7801: // StoneSlab
                case 7807: // SmoothStoneSlab
                case 7813: // SandstoneSlab
                case 7819: // CutSandstoneSlab
                case 7825: // PetrifiedOakSlab
                case 7831: // CobblestoneSlab
                case 7837: // BrickSlab
                case 7843: // StoneBrickSlab
                case 7849: // NetherBrickSlab
                case 7855: // QuartzSlab
                case 7861: // RedSandstoneSlab
                case 7867: // CutRedSandstoneSlab
                case 7873: // PurpurSlab
                case 7309: // PrismarineSlab
                case 7321: // DarkPrismarineSlab
                case 10254: // PolishedGraniteSlab
                case 10260: // SmoothRedSandstoneSlab
                case 10266: // MossyStoneBrickSlab
                case 10272: // PolishedDioriteSlab
                case 10278: // MossyCobblestoneSlab
                case 10284: // EndStoneBrickSlab
                case 10290: // SmoothSandstoneSlab
                case 10296: // SmoothQuartzSlab
                case 10302: // GraniteSlab
                case 10308: // AndesiteSlab
                case 10314: // RedNetherBrickSlab
                case 10320: // PolishedAndesiteSlab
                case 10326: // DioriteSlab
                    return true;
            }
        }
        else if (protocolVersion >= Protocol18Handler.MC_1_14_Version)
        {
            switch (block.BlockId)
            {
                case 7765: // OakSlab
                case 7771: // SpruceSlab
                case 7777: // BirchSlab
                case 7783: // JungleSlab
                case 7789: // AcaciaSlab
                case 7795: // DarkOakSlab
                case 7801: // StoneSlab
                case 7807: // SmoothStoneSlab
                case 7813: // SandstoneSlab
                case 7819: // CutSandstoneSlab
                case 7825: // PetrifiedOakSlab
                case 7831: // CobblestoneSlab
                case 7837: // BrickSlab
                case 7843: // StoneBrickSlab
                case 7849: // NetherBrickSlab
                case 7855: // QuartzSlab
                case 7861: // RedSandstoneSlab
                case 7867: // CutRedSandstoneSlab
                case 7873: // PurpurSlab
                case 7309: // PrismarineSlab
                case 7315: // PrismarineBrickSlab
                case 7321: // DarkPrismarineSlab
                case 10254: // PolishedGraniteSlab
                case 10260: // SmoothRedSandstoneSlab
                case 10266: // MossyStoneBrickSlab
                case 10272: // PolishedDioriteSlab
                case 10278: // MossyCobblestoneSlab
                case 10284: // EndStoneBrickSlab
                case 10290: // SmoothSandstoneSlab
                case 10296: // SmoothQuartzSlab
                case 10302: // GraniteSlab
                case 10308: // AndesiteSlab
                case 10314: // RedNetherBrickSlab
                case 10320: // PolishedAndesiteSlab
                case 10326: // DioriteSlab
                    return true;
            }
        }
        else if (protocolVersion >= Protocol18Handler.MC_1_13_Version)
        {
            switch (block.BlockId)
            {
                case 7258: // OakSlab
                case 7264: // SpruceSlab
                case 7270: // BirchSlab
                case 7276: // JungleSlab
                case 7282: // AcaciaSlab
                case 7288: // DarkOakSlab
                case 7294: // StoneSlab
                case 7300: // SandstoneSlab
                case 7306: // PetrifiedOakSlab
                case 7312: // CobblestoneSlab
                case 7318: // BrickSlab
                case 7324: // StoneBrickSlab
                case 7330: // NetherBrickSlab
                case 7336: // QuartzSlab
                case 7342: // RedSandstoneSlab
                case 7348: // PurpurSlab
                case 6802: // PrismarineSlab
                case 6808: // PrismarineBrickSlab
                case 6814: // DarkPrismarineSlab
                    return true;
            }
        }

        return false;
    }
}