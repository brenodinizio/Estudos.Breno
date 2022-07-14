@ModelType SPH3_TDS.Turno
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Turno</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.TURDESCRICAO)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.TURDESCRICAO)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.TURID }) |
    @Html.ActionLink("Back to List", "Index")
</p>
