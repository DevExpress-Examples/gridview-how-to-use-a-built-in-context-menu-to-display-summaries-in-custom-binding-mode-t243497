﻿@Code
    ViewBag.Title = "How to use a built-in Context Menu to display summaries in Custom Binding mode"
End Code
<script>
    function OnContextMenuItemClick(s, e) {
        if (e.objectType == "footer") {
            e.handled = true;
            gridView.PerformCallback({ fieldName: s.GetColumn(e.elementIndex).fieldName, customCommand: e.item.name });

        }
    }
</script>


@Html.Action("AdvancedCustomBindingPartial")
