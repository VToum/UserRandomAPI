import React, { useState, useEffect } from 'react';
import axios from 'axios';
import { Table, TableBody, TableCell, TableContainer, TableHead, TableRow, Paper, CircularProgress, Box, Button, TextField, Fade } from '@mui/material';
import './Css/UserList.css';

const UserList = () => {
  const [users, setUsers] = useState([]);
  const [loading, setLoading] = useState(false);
  const [page, setPage] = useState(1);
  const [pageSize, setPageSize] = useState(5);

  const fetchUsers = async (pageNumber, pageSize) => {
    setLoading(true);
    try {
      const response = await axios.get('https://localhost:7052/api/Usuario/BuscarTodosUsuarios', {
        params: {
          paginaNumero: pageNumber,
          paginaTamanaho: pageSize
        }
      });
      setUsers(response.data);
      setLoading(false);
    } catch (error) {
      console.error("Erro ao buscar usuários", error);
      setLoading(false);
    }
  };

  const deleteUser = async (id) => {
    try {
      await axios.delete(`https://localhost:7052/api/Usuario/${id}`);
      fetchUsers(page, pageSize); // Atualizar a lista de usuários após a exclusão
    } catch (error) {
      console.error(`Erro ao remover usuário com id ${id}`, error);
    }
  };

  useEffect(() => {
    fetchUsers(page, pageSize);
  }, [page, pageSize]);

  if (loading) {
    return (
      <Box sx={{ display: 'flex', justifyContent: 'center', alignItems: 'center', height: '100vh' }}>
        <CircularProgress />
      </Box>
    );
  }

  return (
    <Box sx={{ display: 'flex', flexDirection: 'column', alignItems: 'center' }}>
      <Box sx={{ marginBottom: '20px' }}>
        <Button variant="contained" color="primary" onClick={() => setPage(prevPage => Math.max(prevPage - 1, 1))}>Página Anterior</Button>
        <Button variant="contained" color="primary" onClick={() => setPage(prevPage => prevPage + 1)} style={{ marginLeft: '10px' }}>Próxima Página</Button><br/><br/>
        <TextField
          label="Usuários por página"
          type="number"
          value={pageSize}
          onChange={e => setPageSize(Number(e.target.value))}
          style={{ marginLeft: '60px' }}
        />
      </Box>
      <Fade in={!loading}>
      <TableContainer component={Paper} style={{maxWidth: '95%', overflowX: 'auto', background: '#f3f3f3',}}>
        <Table sx={{ minWidth: 600 }} aria-label="simple table">
            <TableHead>
              <TableRow>
                <TableCell>ID</TableCell>
                <TableCell align="right">Pais</TableCell>
                <TableCell align="right">Cidade</TableCell>
                <TableCell align="right">Nome</TableCell>
                <TableCell align="right">Email</TableCell>
                <TableCell align="right">Naturalidade</TableCell>
                <TableCell align="right">Ações</TableCell>
              </TableRow>
            </TableHead>
            <TableBody>
              {users.map((user, index) => (
                <TableRow key={user.id || index}>
                  <TableCell component="th" scope="row">
                    {user.login.loginId}
                  </TableCell>
                  <TableCell align="right">{user.location.country}</TableCell>
                  <TableCell align="right">{user.location.state}</TableCell>
                  <TableCell align="right">{user.name.first}</TableCell>
                  <TableCell align="right">{user.email}</TableCell>
                  <TableCell align="right">{user.nat}</TableCell>
                  <TableCell align="right">
                    <Button variant="contained" color="secondary" onClick={() => deleteUser(user.login.loginId)}>
                      Remover
                    </Button>
                  </TableCell>
                </TableRow>
              ))}
            </TableBody>
          </Table>
        </TableContainer>
      </Fade>
    </Box>
  );
};

export default UserList;
