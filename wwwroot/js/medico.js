$(document).ready(function () {
    $('#Medico').on('keypress', function (e) {
        if (e.which == 13) { // Enter key pressed
            e.preventDefault();
            var searchTerm = $(this).val();
            $.get('/api/medicos', { nome: searchTerm }, function (data) {
                var results = $('#medico-search-results');
                results.empty();
                data.forEach(function (medico) {
                    results.append('<li><a href="#" class="select-medico" data-nome="' + medico.crm + ' - ' + medico.nome + '">' + 'Nome: ' + medico.nome + ' CRM: ' + medico.crm + '</a></li>');
                });
                $('#medicoModal').modal('show');
            });
        }
    });

    $(document).on('click', '.select-medico', function (e) {
        e.preventDefault();
        var nome = $(this).data('nome');
        $('#Medico').val(nome);
        $('#medicoModal').modal('hide');
    });

    $('#saveMedicoBtn').on('click', function () {
        var medicoData = {
            Nome: $('#NomeMedico').val(),
            Endereco: $('#EnderecoMedico').val(),
            Bairro: $('#BairroMedico').val(),
            CEP: $('#CepMedico').val(),
            Cidade: $('#CidadeMedico').val(),
            Telefone: $('#TelefoneMedico').val(),
            TipoConselho: $('#TipoConselhoMedico').val(),
            CRM: $('#CRMMedico').val(),
            Sexo: $('#SexoMedico').val(),
            Porc: $('#PorcMedico').val(),
            Interno: $('#InternoMedico').val(),
            Externo: $('#ExternoMedico').val(),
            CodUnimed: $('#CodUnimedMedico').val(),
            VinUnimed: $('#VinUnimedMedico').val(),
            EspUnimed: $('#EspUnimedMedico').val(),
            CodSUS: $('#CodSUSMedico').val(),
            CBOS: $('#cBOSMedico').val(),
            SenhaInternet: $('#SenhaInternetMedico').val(),
            Estrangeiro: $('#EstrangeiroMedico').val(),
            StAtivo: $('#stAtivoMedico').val()
        };
        alert(Sexo);
        $.ajax({
            url: '/api/medicos',
            type: 'POST',
            contentType: 'application/json',
            data: JSON.stringify(medicoData),
            success: function (response) {
                alert('Medico salvo com sucesso!');
                $('#cadastroMedicoModal').modal('hide');
            },
            error: function (xhr) {
                var errors = xhr.responseJSON.errors;
                var errorMessage = "Erro ao salvar medico:\n";
                for (var key in errors) {
                    if (errors.hasOwnProperty(key)) {
                        errorMessage += errors[key] + "\n";
                    }
                }
                alert(errorMessage);
            }
        });
    });
});