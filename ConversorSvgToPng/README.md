# ?? Conversor SVG para PNG

Aplicação Windows Forms moderna para converter ficheiros SVG para PNG com interface drag & drop.

## ? Funcionalidades

- ?? **Drag & Drop**: Arraste múltiplos ficheiros SVG diretamente para a aplicação
- ?? **Tamanho Customizável**: Defina largura e altura da conversão
- ?? **Manter Proporções**: Opção para manter as proporções originais
- ?? **Pasta Automática**: Ficheiros convertidos salvos em pasta "Convertidos" na raiz do executável
- ?? **Conversão em Lote**: Converta múltiplos ficheiros de uma vez
- ?? **Interface Moderna**: Design escuro e intuitivo
- ?? **Barra de Progresso**: Acompanhe o progresso da conversão em tempo real

## ??? Instalação

### Pré-requisitos
- Visual Studio 2017 ou superior
- .NET Framework 4.8

### Passos

1. Abra a solução no Visual Studio

2. **Instale o pacote Svg** via NuGet Package Manager:
   - Clique com o botão direito no projeto > "Manage NuGet Packages"
   - Procure por "Svg"
   - Instale o pacote **Svg** (versão 3.4.4 ou superior)

   **OU via Package Manager Console:**
   ```powershell
   Install-Package Svg -Version 3.4.4
   ```

3. Compile e execute a aplicação (F5)

## ?? Como Usar

1. **Adicionar Ficheiros SVG**:
   - Arraste ficheiros SVG para a área indicada
   - OU clique na área para abrir o seletor de ficheiros

2. **Definir Tamanho**:
   - Digite a largura e altura desejadas (padrão: 512x512)
   - Marque "Manter proporções" para preservar o aspecto original

3. **Converter**:
   - Clique em "?? Converter"
   - Aguarde o processamento
   - Ficheiros serão salvos na pasta "Convertidos"

4. **Abrir Pasta**:
   - Clique em "?? Abrir Pasta" para visualizar os ficheiros convertidos

## ?? Estrutura de Saída

Os ficheiros convertidos são salvos em:
```
[Pasta do Executável]\Convertidos\
```

Formato do nome do ficheiro:
```
nome_original_512x512.png
```

Se já existir um ficheiro com o mesmo nome, um contador será adicionado:
```
nome_original_512x512_1.png
```

## ?? Interface

A aplicação possui:
- **Painel de Drop**: Área drag & drop com feedback visual
- **Controles de Tamanho**: Campos numéricos para largura e altura
- **Lista de Ficheiros**: Visualização dos ficheiros adicionados
- **Barra de Progresso**: Acompanhamento em tempo real
- **Botões de Ação**: Converter, Abrir Pasta, Limpar

## ?? Tecnologias

- **C# 7.3**
- **.NET Framework 4.8**
- **Windows Forms**
- **Svg Library** (Svg.dll) - Para renderização de SVG

## ?? Notas

- A aplicação mantém as proporções originais por padrão
- Suporta tamanhos de 16x16 até 10000x10000 pixels
- Conversão assíncrona para não bloquear a interface
- Cores modernas (tema escuro)

## ?? Resolução de Problemas

### Erro: "O tipo ou nome do namespace 'Svg' não pôde ser encontrado"
**Solução**: Instale o pacote NuGet "Svg" conforme instruções acima.

### Ficheiros não convertem
**Solução**: Verifique se os ficheiros SVG são válidos e não estão corrompidos.

### Pasta "Convertidos" não abre
**Solução**: Execute a primeira conversão para criar a pasta automaticamente.

## ?? Licença

Este projeto é de código aberto e está disponível para uso livre.

---

**Desenvolvido com ?? para facilitar a conversão de SVG para PNG**
