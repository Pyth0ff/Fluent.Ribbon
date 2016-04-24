#pragma warning disable 1591

namespace Fluent.Localization.Languages
{
    [RibbonLocalization("Estonian", "et")]
    public class Estonian : RibbonLocalizationBase
    {
        public override string BackstageButtonText { get; } = "Fail";
        public override string BackstageButtonKeyTip { get; } = "F";
        public override string MinimizeButtonScreenTipTitle { get; } = "Ahenda menüülint (Ctrl+F1)";
        public override string MinimizeButtonScreenTipText { get; } = "Kas vajate rohkem ruumi? Ahendage lint, siis kuvatakse \nainult menüünimed.";
        public override string ExpandButtonScreenTipTitle { get; } = "Kinnita lint (Ctrl+F1)";
        public override string ExpandButtonScreenTipText { get; } = "Kas soovite, et lint oleks kuvatud? Saate selle töötamise \najal avatuna hoida.";
        public override string QuickAccessToolBarDropDownButtonTooltip { get; } = "Kohanda kiirpääsuriba";
        public override string QuickAccessToolBarMoreControlsButtonTooltip { get; } = "Rohkem juhtelemente";
        public override string QuickAccessToolBarMenuHeader { get; } = "Kohanda kiirpääsuriba";
        public override string QuickAccessToolBarMenuShowAbove { get; } = "Kuva lindi kohal";
        public override string QuickAccessToolBarMenuShowBelow { get; } = "Kuva lindi all";
        public override string RibbonContextMenuAddItem { get; } = "Lisa kiirpääsuribale";
        public override string RibbonContextMenuAddGroup { get; } = "Lisa rühm kiirpääsuribale";
        public override string RibbonContextMenuAddGallery { get; } = "Lisa galerii kiirpääsuribale";
        public override string RibbonContextMenuAddMenu { get; } = "Lisa menüü kiirpääsuribale";
        public override string RibbonContextMenuRemoveItem { get; } = "Eemalda kiirpääsuribalt";
        public override string RibbonContextMenuCustomizeQuickAccessToolBar { get; } = "Kohanda kiirpääsuriba...";
        public override string RibbonContextMenuCustomizeRibbon { get; } = "Kohanda linti...";
        public override string RibbonContextMenuMinimizeRibbon { get; } = "Ahenda menüülint";
        public override string RibbonContextMenuShowAbove { get; } = "Kuva kiirpääsuriba lindi kohal";
        public override string RibbonContextMenuShowBelow { get; } = "Kuva kiirpääsuriba lindi all";
        public override string ScreenTipDisableReasonHeader { get; } = "See käsk on praegu keelatud.";
        public override string ScreenTipF1LabelHeader { get; } = "Spikri kuvamiseks vajutage klahvi F1";
        public override string CustomizeStatusBar { get; } = "Kohanda olekuriba";
        public override string NoColor { get; } = "Ei värvi";
    }
}