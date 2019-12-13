<!DOCTYPE html>
<html>

<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Colégio Cavlac</title>
    
    <link rel="shortcut icon" href="img/favicon.ico" />
    <link rel="stylesheet" href="css/style.css">
    <link href="fonts/css/all.css" rel="stylesheet">
    <link rel="stylesheet" href="css/bootstrap.min.css">
    <script src="js/jquery.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <script src="js/script.js"></script>
    <script src="js/informacoes.js"></script>
    <script src="js/ajax.min.js"></script>
    <script src="js/sweetalert2.min.js"></script>
</head>

<body>
    <!--======================================= Barra de Navegação =======================================-->
    <header id="navbar">
        <section class="menu">
            <nav id="navegacao">
                <div id="logo"><img src="img/navLogo.png" alt=""> </div>
                <a class="scrollDirect" href="#carouselExampleIndicators">Início</a>
                <a class="scrollDirect"  href="#niveisEnsino">Ensino</a>
                <a class="scrollDirect"  href="#sobre">Sobre</a>
                <a class="scrollDirect"  href="#galeria">Galeria</a>
                <a class="scrollDirect"  href="#faleConosco">Contato</a>
                <a href="#" data-toggle="modal" data-target="#login">Login</a>
            </nav>
        </section>
    </header>
    
    <!--======================================= Login Modal =======================================-->
    <section id="login" class="modal">
        <div class="modal-content animate">
            <section class="container">
                <h1>Entre com a sua conta</h1><br>
                <form class="form-login"  method="POST" action="aluno/classes/login_action.php">
                    <input type="text" placeholder="Digite seu RA" name="id_matricula" required>
                    <input type="password" placeholder="Digite sua senha" name="senha" required>
                    <button class="botaoLogin" type="submit" name="btLogar">Entrar</button>
                    <button class="botaoLogin" type="button" data-toggle="modal" data-target="#login" data-backdrop="static">Fechar</button>
                </form>
            </section>
        </div>
    </section>

    <!--======================================= SlideShow =======================================-->
    <section id="carouselExampleIndicators" class="carousel slide" data-ride="carousel">
        <div class="overlay"></div>
        <ol class="carousel-indicators">
            <li data-target="#carousel" data-slide-to="0" class="active"></li>
            <li data-target="#carousel" data-slide-to="1"></li>
            <li data-target="#carousel" data-slide-to="2"></li>
        </ol>
        <section class="carousel-inner">
            <!-- Slide One - Set the background image for this slide in the line below -->
            <article class="carousel-item active">
                <hgroup class="carousel-caption d-none d-md-block">
                    <h1>Colégio <span>Cavlac</span></h1>
                    <h3>O melhor para você!</h3>
                </hgroup>
            </article>
            <!-- Slide Two - Set the background image for this slide in the line below -->
            <article class="carousel-item">
                <hgroup class="carousel-caption d-none d-md-block">
                    <h1>Colégio <span>Cavlac</span></h1>
                    <h3>O melhor para você!</h3>
                </hgroup>
            </article>
            <!-- Slide Three - Set the background image for this slide in the line below -->
            <article class="carousel-item">
                <hgroup class="carousel-caption d-none d-md-block">
                    <h1>Colégio <span>Cavlac</span></h1>
                    <h3>O melhor para você!</h3>
                </hgroup>
            </article>
        </section>
        <a class="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-slide="prev">
            <span class="carousel-control-prev-icon"></span>
        </a>
        <a class="carousel-control-next" href="#carouselExampleIndicators" role="button" data-slide="next">
            <span class="carousel-control-next-icon"></span>
        </a>
    </section>


    <!--======================================= Níveis de ensino =======================================-->
    <section id="niveisEnsino">
        <h1>Níveis de <span>Ensino</span></h1>
        <article class="ensino">
            <img src="img/1.jpg" alt="">
            <h3>Educação Infantil</h3>
            <p>
                • Brinquedoteca <br>
                • Cozinha experimental <br>
                • Horta <br>
                • Playground <br>
                • Espaço de leitura <br>
                • Informática educacional <br>
            </p>
        </article>
        <article class="ensino">
            <img src="img/2.jpg" alt="">
            <h3>Ensino Fundamental I</h3>
            <p>
                • Brinquedoteca <br>
                • Cozinha experimental <br>
                • Horta <br>
                • Playground <br>
                • Espaço de leitura <br>
                • Informática educacional <br>
            </p>
        </article>
        <article class="ensino">
            <img src="img/3.jpg" alt="">
            <h3>Ensino Fundamental II</h3>
            <p>
                • Salas de cada disciplina<br>
                • Laboratório equipado <br>
                • Sala de informática<br>
                • 3 salas de multimídia<br>
                • Sala de projeção <br>
                • Quadra esportiva coberta <br>
            </p>
        </article>
        <article class="ensino">
            <img src="img/4.jpg" alt="">
            <h3>Ensino Médio</h3>
            <p>
                • Salas de cada disciplina<br>
                • Laboratório equipado <br>
                • Sala de informática<br>
                • 3 salas de multimídia<br>
                • Sala de projeção <br>
                • Quadra esportiva coberta <br>
            </p>
        </article>
    </section>

    <!--======================================= Sobre =======================================-->
    <section id="sobre">
        <h1>Sobre o <span>Colégio Cavlac</span></h1>
        <ul class="nav nav-tabs">
            <li class="nav-item"><a class="nav-link active" title="História" data-toggle="tab" href="#historia"><i class="fas fa-book"></i></a></li>
            <li class="nav-item"><a class="nav-link" title="Missão" data-toggle="tab" href="#missao"><i class="fas fa-paper-plane"></i></a></li>
            <li class="nav-item"><a class="nav-link" title="Visão" data-toggle="tab" href="#visao"><i class="fas fa-eye"></i></a></li>
            <li class="nav-item"><a class="nav-link" title="Valores" data-toggle="tab" href="#valores"><i class="fas fa-tag"></i></a></li>
            <li class="nav-item"><a class="nav-link" title="Descrição do Logo" data-toggle="tab" href="#descricaoLogo"><i class="fas fa-question-circle"></i></a></li>
        </ul>
        <section class="tab-content">
            <article class="tab-pane fade show active" id="historia">
                <h3>História</h3>
                <p>
                    O colégio foi criado em 1989 sendo fundado por “Maria Leonia Moura Cavlac”, sendo localizado no bairro
                    Parque Paulistano na Zona Leste de São Paulo, possuindo somente a parte de Educação Infantil, sendo o primeiro nome do colégio “Sossego da Mamãe”.
                    <br /><br />
                    Já em 1995 a escola passou a possuir o Ensino Fundamental I e II, mudando de “Sossego da Mamãe” para Colégio Cavlac. Já em 2000 o colégio passou a ter o Ensino Médio.
                </p>
            </article>
            <article class="tab-pane fade" id="missao">
                <h3>Missão</h3>
                <p>Formar cidadãos éticos, empreendedores e preparados para o futuro, por meio de uma proposta pedagógica transformadora, de excelência, em parceria com instituições sociais e empresariais.
                </p>
            </article>
            <article class="tab-pane fade" id="visao">
                <h3>Visão</h3>
                <p>
                    Ser referência em Qualidade de Ensino na Educação Infantil, Ensino Fundamental I, Ensino Fundamental II e Ensino Mé
                    <br /><br />
                    Sendo a melhor opção:
                    <br /><br />
                    Para pais em proporcionar aos seus filhos um ensino de excelência;
                    <br /><br />
                    Para o aluno na construção de sua realização pessoal e profissional pautada na ética que se constitui nos valores, nos princípios e nos direitos humanos;
                    <br />
                    Para profissionais comprometidos com a qualidade, altamente capacitados, criativos e empreendedores.
                </p>
            </article>
            <article class="tab-pane fade" id="valores">
                <h3>Valores</h3>
                <p>
                    <li>Ética no relacionamento com a interpessoalidade.</li>
                    <br />
                    <li>Valorização do ser humano;</li>
                    <br />
                    <li>Liderança transformadora em busca de excelência;</li>
                    <br />
                    <li>Inovação - Aprendizagem contínua com proatividade.</li>
                </p>
            </article>
            <article class="tab-pane fade" id="descricaoLogo">
                <h3>Descrição do Logo</h3>
                <p>
                    O Logotipo é a junção da palavra colégio que significa um estabelecimento de ensi-no junto de Cavlac que seria o sobrenome da pessoa que fundou a escola. O CC na imagem representa a letra inicial das palavras Colégio e Cavlac. O verde não foi uma cor realmente escolhida, poderia ter sido qualquer uma, mas se for analisar o verde, representa estabilidade, associada à saúde e à tranquilidade, representa o crescimento, vitalidade, abundancia na natureza. Simbolo da fertilidade tem efeito calmante e alivia o stress.
                </p>
            </article>
        </section>
    </section>

    <!--======================================= Divisão =======================================-->
    <h1 class="divisao">Colégio Cavlac o melhor para você!</h1>


    <!--======================================= Galeria =======================================-->
    <section id="galeria">
        <h1><span>Galeria</span></h1>
        <p>Não podemos mudar o passado, mas nosso objetivo é construir, juntos com vocês, um país melhor por meio da educação.</p>
        <article class="fotos">
            <div class="foto">
                <img class="imagemGaleria" src="img/galeria/1.jpg">
            </div>
            <div class="foto">
                <img class="imagemGaleria" src="img/galeria/2.jpg">
            </div>
            <div class="foto">
                <img class="imagemGaleria" src="img/galeria/3.jpg">
            </div>
            <div class="foto">
                <img class="imagemGaleria" src="img/galeria/4.jpg">
            </div>
            <div class="foto">
                <img class="imagemGaleria" src="img/galeria/5.jpg">
            </div>
            <div class="foto">
                <img class="imagemGaleria" src="img/galeria/6.jpg">
            </div>
            <div class="foto">
                <img class="imagemGaleria" src="img/galeria/7.jpg">
            </div>
            <div class="foto">
                <img class="imagemGaleria" src="img/galeria/8.jpg">
            </div>
            <div class="foto">
                <img class="imagemGaleria" src="img/galeria/9.jpg">
            </div>
            <div class="foto">
                <img class="imagemGaleria" src="img/galeria/10.jpg">
            </div>
            <div class="foto">
                <img class="imagemGaleria" src="img/galeria/11.jpg">
            </div>
            <div class="foto">
                <img class="imagemGaleria" src="img/galeria/12.jpg">
            </div>
            <div class="foto">
                <img class="imagemGaleria" src="img/galeria/13.jpg">
            </div>
            <div class="foto">
                <img class="imagemGaleria" src="img/galeria/14.jpg">
            </div>
            <div class="foto">
                <img class="imagemGaleria" src="img/galeria/15.jpg">
            </div>
            <div class="foto">
                <img class="imagemGaleria" src="img/galeria/16.jpg">
            </div>
        </article>
    </section>

    <!--======================================= Divisão =======================================-->
    <h1 class="divisaoFaleConosco">Fale Conosco</h1>

    <!--======================================= Fale Conosco =======================================-->
    <section id="faleConosco">
        <form class="contatos" formmethod="POST">
            <div class="campoDuplo">
                <div class="icone"><i class="fas fa-user-alt"></i></div><input type="text" name="nome" id="nome" placeholder="Digite o seu nome">
            </div>
            <div class="campoDuplo">
                <div class="icone"><i class="fas fa-user-alt"></i></div><input type="text" name="sobrenome" id="sobrenome" placeholder="Digite o seu sobrenome">
            </div>
            <div class="campoDuplo">
                <div class="icone"><i class="fas fa-phone"></i></div><input type="numeric" name="telefone" id="telefone" placeholder="Digite o seu telefone">
            </div>
            <div class="campoDuplo">
                <div class="icone"><i class="fas fa-pencil-alt"></i></div>
                <select type="text" name="assunto" id="assunto" required>
                    <option value="" disabled selected>Escolha o Assunto</option>
                    <option value="Aulas">Aulas</option>
                    <option value="Colégio">Colégio</option>
                    <option value="Sugestões">Sugestões</option>
                    <option value="Reclamações">Reclamações</option>
                    <option value="Outros">Outros</option>
                </select>
            </div>
            <div class="campo">
                <div class="icone"><i class="fas fa-envelope"></i></div><input type="email" name="email" id="email" placeholder="Digite o seu e-mail">
            </div>
            <div class="campoMensagem">
                <div class="icone"><i class="fas fa-comment"></i></div><textarea name="mensagem" id="mensagem" placeholder="Digite a Mensagem"></textarea>
            </div>
            <div class="botao">
                <button type="submit" name="enviar" id="enviar">Enviar Mensagem</button>
                <div class="loading"></div>
            </div>
            <div class="mostrar"></div>
        </form>
        <form class="enderecos">
            <legend><i class="fas fa-globe-americas"></i> Nossos Contatos </legend>
            <hr>
            <address>
                <strong>Colégio Cavlac</strong><br>
                R. Pedroso da Silva, 482<br>
                Parque Paulistano, São Paulo - SP, 08080-160<br><br />
                <strong>Telefone:</strong><br>
                <a>(11) 2581-6000</a>
            </address>
            <address>
                <strong>Email:</strong><br>
                <a href="mailto:#">acontecenocolegiocavlac@gmail.com</a>
            </address>
        </form>
    </section>

    <!--======================================= Rodapé =======================================-->
    <footer>
        <div class="rodape">
            <img src="img/logoTeste.png" alt="">
            <adress class="redesSociais">
                <a href="https://pt-br.facebook.com/colegiocavlac/"><i class="fab fa-facebook"></i></a>
                <a href="https://twitter.com/cavlac"><i class="fab fa-twitter"></i></a>
                <a href="https://plus.google.com/107458146206308797477"><i class="fab fa-google-plus"></i></a>
            </adress>
            <p>Colégio Cavlac © 2017</p>
        </div>
    </footer>
</body>

</html>
