
# JogoDaVelha

Projetos simples desenvolvido no curso  Técnico em Desenvolvimentos de Sistemas do Senac Pindamonhangaba.
O jogo utiliza Objeto _sender_ para manipulação do Objeto que chama da forma mais eficiente.

# Como funciona? 
Visão Geral
O Jogo da Velha (Tic Tac Toe) é uma aplicação gráfica desenvolvida com a tecnologia Windows Forms em C#, permitindo que dois jogadores disputem em tempo real clicando nos botões da interface. O objetivo é alinhar três símbolos iguais (X ou O) em linha reta — seja na horizontal, vertical ou diagonal.

🧱 Estrutura da Interface (UI)
A interface é composta por 9 botões dispostos em uma grade 3x3, representando o tabuleiro do jogo.

Há também botões auxiliares como “Reiniciar” e um rótulo (Label) para exibir o jogador atual ou o resultado da partida.

⚙️ Funcionamento Lógico
Inicialização do Jogo:

Ao iniciar, o jogo define que o primeiro jogador será o "X".

Todos os botões do tabuleiro são habilitados e estão vazios.

Jogada do Usuário:

O jogador clica em um botão (célula).

O botão clicado recebe o símbolo do jogador atual ("X" ou "O") e é desabilitado para evitar nova jogada na mesma célula.

Após a jogada, o sistema:

Verifica se houve vencedor.

Verifica se houve empate.

Alterna para o próximo jogador, se o jogo continuar.

Verificação de Vitória:

O código checa todas as possíveis combinações vencedoras (linhas, colunas e diagonais).

Se encontrar três símbolos iguais em linha, o jogo exibe o vencedor e desativa todos os botões.

Empate:

Se todos os botões estiverem preenchidos sem vitória, o jogo declara empate.

Reiniciar:

O botão “Reiniciar” limpa todos os botões, reabilita o tabuleiro e define "X" como jogador inicial novamente.

💻 Recursos Utilizados no Código
Eventos Click: Cada botão do tabuleiro possui um evento Click associado que executa a jogada.

Controle de Estado: Variáveis booleanas e strings são usadas para armazenar o jogador atual, contagem de jogadas, etc.

Funções de Verificação: Métodos dedicados verificam a condição de vitória ou empate após cada jogada.

Estética e Usabilidade: Pode-se adicionar feedback visual (cores, fontes, mensagens) para uma experiência mais intuitiva.

📌 Exemplo de Componentes Usados
Button (para células e botão reiniciar)

Label (para mostrar mensagens e jogador da vez)

Form (janela principal do jogo)