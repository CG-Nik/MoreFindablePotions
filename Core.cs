using Alta.Caves;
using Alta.Liquid;
using MelonLoader;
using UnityEngine;

[assembly: MelonInfo(typeof(MoreFindablePotions.Core), "MoreFindablePotions", "1.0.0", "CGNik", null)]
[assembly: MelonGame("Alta", "A Township Tale")]

namespace MoreFindablePotions
{
    public class Core : MelonMod
    {
        public override void OnInitializeMelon()
        {
            LoggerInstance.Msg("Initialized.");
        }

        public override void OnLateInitializeMelon()
        {
            Distribution liquidDistribution = Distribution.All.Where(dist => dist.Hash == 26032u).First();

            CustomDistributionAPI.Core.AddToDistribution(
                liquidDistribution,
                LiquidDefinition.All.Where(liquid => liquid.Hash == 46018u).First(),
                0.25f,
                0.25f,
                new AttributeCurveRange[]
                {
                    new AttributeCurveRange(
                        (BiomeAttribute)Resources.FindObjectsOfTypeAll(typeof(BiomeAttribute)).Where(attribute => attribute.name == "_Depth").First(),
                        new AnimationCurve(new Keyframe[]
                        {
                            new Keyframe(0f, 1f),
                            new Keyframe(1f, 0f)
                        }),
                        0f,
                        100f
                    )
                }
            );

            CustomDistributionAPI.Core.AddToDistribution(
                liquidDistribution,
                LiquidDefinition.All.Where(liquid => liquid.Hash == 1180u).First(),
                0.25f,
                0.25f,
                new AttributeCurveRange[]
                {
                    new AttributeCurveRange(
                        (BiomeAttribute)Resources.FindObjectsOfTypeAll(typeof(BiomeAttribute)).Where(attribute => attribute.name == "_Depth").First(),
                        new AnimationCurve(new Keyframe[]
                        {
                            new Keyframe(0f, 1f),
                            new Keyframe(1f, 0f)
                        }),
                        0f,
                        100f
                    )
                }
            );

            CustomDistributionAPI.Core.AddToDistribution(
                liquidDistribution,
                LiquidDefinition.All.Where(liquid => liquid.Hash == 44872u).First(),
                0.25f,
                0.25f,
                new AttributeCurveRange[]
                {
                    new AttributeCurveRange(
                        (BiomeAttribute)Resources.FindObjectsOfTypeAll(typeof(BiomeAttribute)).Where(attribute => attribute.name == "_Depth").First(),
                        new AnimationCurve(new Keyframe[]
                        {
                            new Keyframe(0f, 1f),
                            new Keyframe(1f, 0f)
                        }),
                        0f,
                        100f
                    )
                }
            );

            CustomDistributionAPI.Core.AddToDistribution(
                liquidDistribution,
                LiquidDefinition.All.Where(liquid => liquid.Hash == 15340u).First(),
                0.5f,
                0.5f,
                new AttributeCurveRange[]
                {
                    
                }
            );

            CustomDistributionAPI.Core.AddToDistribution(
                liquidDistribution,
                LiquidDefinition.All.Where(liquid => liquid.Hash == 19126u).First(),
                0.25f,
                0.25f,
                new AttributeCurveRange[]
                {
                    
                }
            );

            CustomDistributionAPI.Core.AddToDistribution(
                liquidDistribution,
                LiquidDefinition.All.Where(liquid => liquid.Hash == 13764u).First(),
                0.25f,
                0.25f,
                new AttributeCurveRange[]
                {
                    
                }
            );
        }
    }
}