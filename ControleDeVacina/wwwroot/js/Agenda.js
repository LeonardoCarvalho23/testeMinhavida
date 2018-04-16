$(document).ready(function () {
   
});

$('#Agendamentos').DataTable();

function ObterAgendamentos() {
    $.ajax({
        url: "",
        cache: false,
        success: function (data) {
            for (i = 0; i < data.length; i++) {
                $('#Agendamentos').row.add([
                    data.Nome,
                    Data.DataFormatada
                ]).draw(false);
            }
        }
    });
    
    
    }