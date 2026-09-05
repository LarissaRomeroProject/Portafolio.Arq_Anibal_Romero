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
                Primary = new MudColor("#3A3532"),      
                Secondary = new MudColor("#2C3E50"),    
                Background = new MudColor("#FFFFFF"),
                AppbarBackground = new MudColor("#D7D8D9"),
                DrawerBackground = new MudColor("#D7D8D9"),
                DrawerText = new MudColor("#080B0D"),
                TextPrimary = new MudColor("#000000"),
                TextSecondary = new MudColor("#7F8C8D"),
                ActionDefault = new MudColor("#C9A96E"),
                Surface = new MudColor("#080B0D"),
                Divider = new MudColor("#E0E0E0"),
                Success = new MudColor("#27AE60"),
                Warning = new MudColor("#F39C12"),
                Error = new MudColor("#E74C3C"),
                Info = new MudColor("#3498DB"),
                Dark = new MudColor("#000000"),
            },
            LayoutProperties = new LayoutProperties
            {
                DefaultBorderRadius = "8px"
            },
            Typography = new Typography
            {
                Default = new DefaultTypography
                {
                    FontFamily = new[] { "Poppins", "sans-serif" }
                },

                H1 = new H1Typography
                {
                    FontFamily = new[] { "Poppins", "sans-serif" },
                    FontWeight = "700"
                },

                H2 = new H2Typography
                {
                    FontFamily = new[] { "Poppins", "sans-serif" },
                    FontWeight = "600"
                },

                H3 = new H3Typography
                {
                    FontFamily = new[] { "Poppins", "sans-serif" },
                    FontWeight = "600"
                },

                H4 = new H4Typography
                {
                    FontFamily = new[] { "Poppins", "sans-serif" },
                    FontWeight = "500"
                },

                Button = new ButtonTypography
                {
                    FontFamily = new[] { "Poppins", "sans-serif" },
                    FontWeight = "500"
                }
            }
        };

        
    }
}
