using MudBlazor;
using MudBlazor.Utilities;

namespace Portafolio.Arq_Anibal_Romero.Themes
{
    public class ArquitectoTheme
    {
        public static MudTheme LightTheme = new MudTheme
        {
            PaletteLight = new PaletteLight
            {
                Primary = new MudColor("#2E2A27"),
                Secondary = new MudColor("#C9A96E"),
                Background = new MudColor("#FAF9F7"),
                AppbarBackground = new MudColor("#FAF9F7"),
                DrawerBackground = new MudColor("#FAF9F7"),
                DrawerText = new MudColor("#211E1C"),
                TextPrimary = new MudColor("#211E1C"),
                TextSecondary = new MudColor("#78716C"),
                ActionDefault = new MudColor("#C9A96E"),
                Surface = new MudColor("#FFFFFF"),
                Divider = new MudColor("#E7E5E4"),
                Success = new MudColor("#27AE60"),
                Warning = new MudColor("#F39C12"),
                Error = new MudColor("#E74C3C"),
                Info = new MudColor("#3498DB"),
                Dark = new MudColor("#211E1C"),
            },
            LayoutProperties = new LayoutProperties
            {
                DefaultBorderRadius = "2px"
            },
            Typography = new Typography
            {
                Default = new DefaultTypography
                {
                    FontFamily = new[] { "Inter", "sans-serif" },
                    LineHeight = "1.7"
                },

                H1 = new H1Typography
                {
                    FontFamily = new[] { "Poppins", "sans-serif" },
                    FontWeight = "700",
                    FontSize = "clamp(2.75rem, 6vw, 5.5rem)",
                    LineHeight = "1.02",
                    LetterSpacing = "-0.03em"
                },

                H2 = new H2Typography
                {
                    FontFamily = new[] { "Poppins", "sans-serif" },
                    FontWeight = "700",
                    FontSize = "clamp(2.25rem, 5vw, 4rem)",
                    LineHeight = "1.05",
                    LetterSpacing = "-0.02em"
                },

                H3 = new H3Typography
                {
                    FontFamily = new[] { "Poppins", "sans-serif" },
                    FontWeight = "600",
                    FontSize = "clamp(1.75rem, 3vw, 2.5rem)",
                    LetterSpacing = "-0.01em"
                },

                H4 = new H4Typography
                {
                    FontFamily = new[] { "Poppins", "sans-serif" },
                    FontWeight = "500"
                },

                H5 = new H5Typography
                {
                    FontFamily = new[] { "Poppins", "sans-serif" },
                    FontWeight = "600",
                    LetterSpacing = "-0.01em"
                },

                Button = new ButtonTypography
                {
                    FontFamily = new[] { "Poppins", "sans-serif" },
                    FontWeight = "600",
                    LetterSpacing = "0.06em"
                }
            }
        };

        
    }
}
