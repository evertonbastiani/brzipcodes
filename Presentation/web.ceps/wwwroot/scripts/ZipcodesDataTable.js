function CreateDataTable(tableId) {
    $(document).ready(function(){
        $(tableId).DataTable();
    });
}

function DestroyDataTable(tableId) {
    $(document).ready(function () {
        $(tableId).DataTable().destroy();
    });
}
