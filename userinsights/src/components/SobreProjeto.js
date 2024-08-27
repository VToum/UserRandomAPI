import React from 'react';
import { Box, Typography } from '@mui/material';

const SobreProjeto = () => {
  return (
    <Box sx={{ 
      display: 'flex', 
      flexDirection: 'column', 
      alignItems: 'flex-start', 
      padding: '20px',
      backgroundColor: '#fafafa',
      borderRadius: '15px',
      boxShadow: '0 3px 6px rgba(0,0,0,0.16), 0 3px 6px rgba(0,0,0,0.23)',
      maxWidth: '800px',
      margin: '50px auto',
      fontFamily: 'Arial',
      marginBottom: '300px',
      '@media (max-width:600px)': {
        width: '100%',
        padding: '10px',
      },
    }}>
      <Typography variant="h4" gutterBottom sx={{ color: '#3f51b5', textAlign: 'left', marginBottom: '20px' }}>
        Sobre este projeto
      </Typography>
      <Typography variant="body1" paragraph sx={{ textAlign: 'justify', textJustify: 'inter-word', marginBottom: '20px' }}>
        Este projeto é uma aplicação React que consome a API RandomUser. A aplicação busca dados de usuários de forma assíncrona e os armazena em um banco de dados. Os dados dos usuários são então exibidos em uma tabela no corpo da aplicação.
      </Typography>
      <Typography variant="body1" paragraph sx={{ textAlign: 'justify', textJustify: 'inter-word', marginBottom: '20px' }}>
        A aplicação utiliza várias funcionalidades do React e de bibliotecas externas. O estado dos usuários, o estado de carregamento, a página atual e o tamanho da página são gerenciados usando o hook `useState` do React. A função `fetchUsers` é usada para buscar os dados dos usuários da API RandomUser. Esta função é chamada dentro do hook `useEffect` do React, que é acionado sempre que a página ou o tamanho da página são alterados.
      </Typography>
      <Typography variant="body1" paragraph sx={{ textAlign: 'justify', textJustify: 'inter-word', marginBottom: '20px' }}>
        Se a aplicação estiver carregando os dados dos usuários, um indicador de progresso circular é exibido. Uma vez que os dados são carregados, eles são exibidos em uma tabela. A tabela inclui colunas para o ID, país, cidade, nome, email e naturalidade do usuário.
      </Typography>
      <Typography variant="body1" paragraph sx={{ textAlign: 'justify', textJustify: 'inter-word', marginBottom: '20px' }}>
        Os usuários podem navegar entre as páginas de usuários usando os botões "Página Anterior" e "Próxima Página". Eles também podem alterar o número de usuários exibidos por página usando um campo de texto.
      </Typography>
      <Typography variant="h5" gutterBottom sx={{ color: '#3f51b5', textAlign: 'left', marginBottom: '20px' }}>
        Minhas Habilidades
      </Typography>
      <Typography variant="body1" paragraph sx={{ textAlign: 'justify', textJustify: 'inter-word', marginBottom: '20px' }}>
        Este projeto serve como uma demonstração das minhas habilidades em React, gerenciamento de estado, chamadas de API assíncronas e uso de bibliotecas externas. Ele faz parte do meu portfólio de projetos. Aqui estão algumas das minhas habilidades destacadas neste projeto:

        - **Linguagens de Programação**: Proficiente em C# e familiarizado com outras linguagens de programação.
        - **Desenvolvimento Web**: Experiência em construção de aplicações web usando React e consumo de APIs RESTful.
        - **Banco de Dados**: Experiência em trabalhar com bancos de dados para armazenar e recuperar informações de usuários.
        - **IDEs**: Confortável em trabalhar com IDEs modernos e uso eficaz de suas ferramentas e recursos.
        - **Controle de Versão**: Familiaridade com o controle de versão de código usando Git ou outras ferramentas similares.
      </Typography>
    </Box>
  );
};

export default SobreProjeto;
