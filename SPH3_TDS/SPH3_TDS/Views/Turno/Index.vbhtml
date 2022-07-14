@ModelType IEnumerable(Of SPH3_TDS.Turno)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.TURDESCRICAO)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.TURDESCRICAO)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.TURID }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.TURID }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.TURID })
        </td>
    </tr>
Next

</table>
