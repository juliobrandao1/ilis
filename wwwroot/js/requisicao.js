function saveRequisicaoBtn() {
    var requisicaoData = {
        codRequisicao: "0", // ou outro valor apropriado
        pedido: "0",
        posto: "0",
        computador: "0", // ou outro valor apropriado      
        acessoInternet: "2025-01-01",
        internet: "N",
        medico: $('#Medico').val().split(" ", 1),
        guia: "",
        guiaPrincipal: "",
        guiaData: "2025-01-01",
        guiaDataAutorizacao: "2025-01-01",
        guiaSenha: "",
        guiaSenhaValidade: "",
        plano: $('#Plano').val(),
        carteirinha: $('#Carteirinha').val(),
        validadeCarteirinha: $('#ValidadeCarteirinha').val(),
        leito: $('#Leito').val(),
        observacao: $('#Observacao').val(),
        obsMedicamento: $('#Medicamentos').val(),
        previsaoEntrega: "2025-01-01",
        paciente: "0", // ou outro valor apropriado
        contrato: $('#Contrato').val(),
        fatura: "0", // ou outro valor apropriado
        lancamento: "",
        faturamento: "",
        origem: "",
        postosus: "0", // ou outro valor apropriado
        urgente: "N",
        parcial: "N",
        bruto: "0.0", // ou outro valor apropriado
        desconto: "0.0", // ou outro valor apropriado
        acrescimo: "0.0", // ou outro valor apropriado
        coleta: "0.0", // ou outro valor apropriado
        total: "0.0", // ou outro valor apropriado
        pago: "0.0",
        particular: "N",
        usuarioCad: "0", // ou outro valor apropriado
        obsBio: "",
        podeAssinar: "N",
        bloqueado: "N",
        faturavel: "N",
        statusId: "1"
    };
    alert(JSON.stringify(requisicaoData));
    $.ajax({
        url: '/api/requisicao',
        type: 'POST',
        contentType: 'application/json',
        data: JSON.stringify(requisicaoData),
        success: function (response) {
            alert('Requisição salva com sucesso!');
        },
        error: function (xhr, status, error) {
            console.log('Erro na solicitação AJAX:', error);
            console.log('Status:', status);
            console.log('Resposta completa:', xhr);
            // Verificar se a resposta contém um objeto JSON
            var response = xhr.responseJSON || {};
            if (response.errors) {
                console.log('Erros:', response.errors);
            } else {
                console.log('Nenhum erro encontrado na resposta.');
            }
        }
    });

};