$(document).ready(function () {
    $('#Paciente').on('keypress', function (e) {
        if (e.which == 13) { // Enter key pressed
            e.preventDefault();
            var searchTerm = $(this).val();
            $.get('/api/pacientes', { nome: searchTerm }, function (data) {
                var results = $('#paciente-search-results');
                results.empty();
                alert(data);
                data.forEach(function (paciente) {
                    results.append('<li><a href="#" class="select-paciente" data-nome="' + paciente.id + ' - ' + paciente.nome + ' ' + paciente.sobrenome + '">' + 'Nome: ' + paciente.nome + ' ' + paciente.sobrenome + ' CPF:' + paciente.cpf + '</a></li>');
                });
                $('#pacienteModal').modal('show');
            });
        }
    });

    $(document).on('click', '.select-paciente', function (e) {
        e.preventDefault();
        var nome = $(this).data('nome');
        var sexo = $(this).data('sexo');
        $('#Paciente').val(nome);
        if (sexo == H) { $('#SexoCadastro').val() == "Masculino" };
        if (sexo == M) { $('#SexoCadastro').val() == "Feminino" };
        if (sexo == O) { $('#SexoCadastro').val() == "Outros" };
        $('#SexoCadastro').val(sexo)
        $('#pacienteModal').modal('hide');
    });

    $('#savePacienteBtn').on('click', function () {
        var pacienteData = {
            Nome: $('#Nome').val(),
            Sobrenome: $('#Sobrenome').val(),
            RG: $('#RG').val(),
            CPF: $('#CPF').val(),
            CNS: $('#CNS').val(),
            Endereco: $('#Endereco').val(),
            Bairro: $('#Bairro').val(),
            CEP: $('#CEP').val(),
            Cidade: $('#Cidade').val(),
            DtaNascimento: $('#DtaNascimento.form-control').val(),
            Sexo: $('#Sexo.form-control').val().indexOf(0),
            Preferencial: $('#Preferencial.form-control').val() == "Sim" ? true : false,
            CodAcesso: $('#CodAcesso').val(),
            Telefone: $('#Telefone').val(),
            Email: $('#Email.form-control').val(),
            Celular: $('#Celular').val()
        };
        alert(Sexo);
        $.ajax({
            url: '/api/pacientes',
            type: 'POST',
            contentType: 'application/json',
            data: JSON.stringify(pacienteData),
            success: function (response) {
                alert('Paciente salvo com sucesso!');
                $('#cadastroPacienteModal').modal('hide');
            },
            error: function (xhr) {
                var errors = xhr.responseJSON.errors;
                var errorMessage = "Erro ao salvar paciente:\n";
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