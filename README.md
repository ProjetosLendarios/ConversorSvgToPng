# 🎨 ConversorSvgToPng

<div align="center">

**Conversor profissional de SVG para PNG com interface moderna**

[![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.8-512BD4?logo=.net)](https://dotnet.microsoft.com/)
[![C#](https://img.shields.io/badge/C%23-7.3-239120?logo=c-sharp)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![Windows Forms](https://img.shields.io/badge/Windows%20Forms-Desktop-0078D6?logo=windows)](https://docs.microsoft.com/en-us/dotnet/desktop/winforms/)
[![License](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE)

![screenshot-placeholder](https://via.placeholder.com/800x450/1E1E1E/FFFFFF?text=ConversorSvgToPng+-+Interface+Moderna)

</div>

---

## 📋 Índice

- [Sobre o Projeto](#-sobre-o-projeto)
- [Funcionalidades](#-funcionalidades)
- [Pré-requisitos](#-pré-requisitos)
- [Instalação](#-instalação)
- [Como Usar](#-como-usar)
- [Configuração](#-configuração)
- [Tamanhos Recomendados](#-tamanhos-recomendados)
- [Estrutura do Projeto](#-estrutura-do-projeto)
- [Detalhes Técnicos](#-detalhes-técnicos)
- [Resolução de Problemas](#-resolução-de-problemas)
- [Contribuir](#-contribuir)
- [Licença](#-licença)

---

## 🎯 Sobre o Projeto

**ConversorSvgToPng** é uma aplicação desktop Windows que permite converter ficheiros SVG (Scalable Vector Graphics) para PNG (Portable Network Graphics) com controle total sobre dimensões e qualidade.

Ideal para designers, desenvolvedores e qualquer pessoa que precise converter imagens vetoriais para formato raster mantendo alta qualidade e controle sobre o tamanho final.

### ✨ Por que usar este conversor?

- ✅ **Interface intuitiva** - Drag & Drop simples e eficiente
- ✅ **Conversão em lote** - Processe múltiplos ficheiros de uma vez
- ✅ **Controle total** - Defina largura e altura personalizadas
- ✅ **Alta qualidade** - Mantém transparências e cores fiéis
- ✅ **Gratuito e open-source** - Use e modifique livremente

---

## 🚀 Funcionalidades

### Principais Recursos

| Funcionalidade | Descrição |
|----------------|-----------|
| 🎯 **Drag & Drop** | Arraste múltiplos ficheiros SVG diretamente para a aplicação |
| 📁 **Seleção de Ficheiros** | Dialog para selecionar múltiplos ficheiros SVG |
| 📏 **Controle de Tamanho** | Ajuste largura e altura de 16 a 10.000 pixels |
| 🔄 **Manter Proporções** | Opção para preservar o aspecto original do SVG |
| ⚡ **Conversão Assíncrona** | Interface não trava durante a conversão |
| 📊 **Barra de Progresso** | Acompanhe o progresso em tempo real |
| 📋 **Lista de Ficheiros** | Visualize todos os ficheiros adicionados |
| 📂 **Pasta Automática** | Cria pasta "Convertidos" automaticamente |
| 🎨 **Interface Moderna** | Design escuro e intuitivo (Dark Mode) |
| 🖱️ **Efeitos Hover** | Feedback visual nos botões e controles |
| 💾 **Nomenclatura Inteligente** | Nomes automáticos: `arquivo_512x512.png` |
| ✅ **Feedback Visual** | Status colorido: amarelo (processando), verde (sucesso), vermelho (erro) |
| 🛠️ **Tratamento de Erros** | Gerenciamento completo de exceções |

---

## 📦 Pré-requisitos

### Sistema Operacional
- **Windows 7** ou superior
- **.NET Framework 4.8** ([Download](https://dotnet.microsoft.com/download/dotnet-framework/net48))

### Para Desenvolvimento
- **Visual Studio 2019** ou superior (Community, Professional ou Enterprise)
- **NuGet Package Manager** (incluído no Visual Studio)

---

## 🔧 Instalação

### 1️⃣ Clonar o Repositório

```bash
git clone https://github.com/ProjetosLendarios/ConversorSvgToPng.git
cd ConversorSvgToPng
```

### 2️⃣ Abrir no Visual Studio

1. Navegue até a pasta `ConversorSvgToPng`
2. Abra o ficheiro `ConversorSvgToPng.sln` ou `ConversorSvgToPng.slnx`

### 3️⃣ Instalar Pacote NuGet (OBRIGATÓRIO)

A aplicação depende do pacote **Svg** para processar ficheiros SVG.

#### Método A: Via Interface (Recomendado)

1. No **Solution Explorer**, clique com o botão direito em `ConversorSvgToPng`
2. Selecione **"Manage NuGet Packages..."**
3. Clique na aba **"Browse"**
4. Procure por: **Svg**
5. Selecione o pacote **"Svg"** (versão 3.4.7 ou superior)
6. Clique em **"Install"**
7. Aceite as licenças

#### Método B: Via Package Manager Console

```powershell
Install-Package Svg
```

### 4️⃣ Compilar o Projeto

1. Pressione **F6** ou vá em **Build > Build Solution**
2. Aguarde a compilação terminar
3. Verifique se não há erros

### 5️⃣ Executar a Aplicação

1. Pressione **F5** ou clique em **Start**
2. A aplicação abrirá pronta para uso!

---

## 💻 Como Usar

### Passo a Passo Básico

1. **Adicionar Ficheiros SVG**
   - Arraste ficheiros SVG para a área indicada, **OU**
   - Clique na área de drop para abrir o seletor de ficheiros

2. **Configurar Tamanho**
   - Defina a **largura** e **altura** desejadas (16 a 10.000 pixels)
   - Marque **"Manter Proporções"** para preservar o aspecto original

3. **Converter**
   - Clique no botão **"🎨 Converter"**
   - Acompanhe o progresso na barra de status

4. **Acessar Ficheiros Convertidos**
   - Clique em **"📂 Abrir Pasta"** para ver os PNG gerados
   - Os ficheiros estarão na pasta `Convertidos` junto ao executável

### Interface da Aplicação

```
╔══════════════════════════════════════════════════╗
║  🎯 Arraste os ficheiros SVG aqui                ║
║     ou clique para selecionar                    ║
║                                                  ║
║     [Área de Drag & Drop]                       ║
╚══════════════════════════════════════════════════╝

Tamanho: [512] × [512]  ☑ Manter proporções

[🎨 Converter] [📂 Abrir Pasta] [🗑️ Limpar]

📋 Lista de Ficheiros ═══════════════════════════
├─ ficheiro1.svg
├─ ficheiro2.svg
└─ ficheiro3.svg
═════════════════════════════════════════════════

Status: Pronto para converter
[████████████████████████] 100%
```

### Conversão em Lote para Múltiplos Tamanhos

Para gerar um mesmo SVG em diferentes tamanhos:

1. Adicione os ficheiros SVG
2. Configure o primeiro tamanho (ex: 512x512)
3. Clique em **"🎨 Converter"**
4. Mude o tamanho (ex: 256x256)
5. Clique em **"🎨 Converter"** novamente
6. Repita para cada tamanho desejado

---

## ⚙️ Configuração

### Controles Disponíveis

| Controle | Função | Valores |
|----------|--------|---------|
| **Largura** | Define a largura do PNG | 16 - 10.000 pixels |
| **Altura** | Define a altura do PNG | 16 - 10.000 pixels |
| **Manter Proporções** | Preserva aspecto original do SVG | Ativado/Desativado |
| **🎨 Converter** | Inicia conversão dos ficheiros | - |
| **📂 Abrir Pasta** | Abre pasta "Convertidos" | - |
| **🗑️ Limpar** | Remove ficheiros da lista | - |

### Nomenclatura dos Ficheiros

Os ficheiros convertidos seguem o padrão:

```
nome_original_LARGURAxALTURA.png
```

**Exemplos:**
- `logo.svg` → `logo_512x512.png`
- `icone.svg` → `icone_256x256.png`
- `banner.svg` → `banner_1920x1080.png`

Se o ficheiro já existir, um contador é adicionado:
- `logo_512x512.png`
- `logo_512x512_1.png`
- `logo_512x512_2.png`

---

## 📐 Tamanhos Recomendados

### 🎨 Ícones

| Tamanho | Uso |
|---------|-----|
| 16×16 | Favicon pequeno |
| 32×32 | Ícone padrão Windows |
| 64×64 | Ícone médio |
| 128×128 | Ícone grande |
| 256×256 | Ícone extra grande |
| 512×512 | Ícone HD |
| 1024×1024 | Ícone Retina/4K |

### 📱 Redes Sociais

| Plataforma | Tamanho |
|------------|---------|
| Facebook/LinkedIn | 1200×630 |
| Instagram (Quadrado) | 1080×1080 |
| Instagram Stories | 1080×1920 |
| Twitter | 1200×675 |
| Avatar Geral | 800×800 |

### 🌐 Web

| Uso | Tamanho |
|-----|---------|
| Full HD | 1920×1080 |
| HD | 1280×720 |
| Web Padrão | 800×600 |
| Thumbnail | 150×150 |

---

## 📁 Estrutura do Projeto

```
ConversorSvgToPng/
│
├── ConversorSvgToPng/
│   ├── ConversorSvgToPng/
│   │   ├── Form1.cs                  # Lógica principal da aplicação
│   │   ├── Form1.Designer.cs         # Design da interface (auto-gerado)
│   │   ├── Program.cs                # Ponto de entrada (Main)
│   │   ├── ConversorSvgToPng.csproj  # Configuração do projeto
│   │   ├── packages.config           # Dependências NuGet
│   │   ├── App.config                # Configurações da aplicação
│   │   │
│   │   ├── Properties/
│   │   │   ├── AssemblyInfo.cs       # Informações do assembly
│   │   │   ├── Resources.resx        # Recursos da aplicação
│   │   │   └── Settings.settings     # Configurações
│   │   │
│   │   └── Documentação/
│   │       ├── COMECE_AQUI.txt       # Guia rápido
│   │       ├── RESUMO_PROJETO.txt    # Resumo detalhado
│   │       ├── INSTALAR_PACOTE.txt   # Instruções NuGet
│   │       ├── DICAS_DE_USO.txt      # Dicas e truques
│   │       └── exemplo_teste.svg     # Ficheiro SVG de exemplo
│   │
│   └── ConversorSvgToPng.slnx        # Solução Visual Studio
│
├── .gitignore                         # Ficheiros ignorados pelo Git
├── .gitattributes                     # Atributos Git
└── README.md                          # Este ficheiro
```

---

## 🔬 Detalhes Técnicos

### Tecnologias Utilizadas

| Tecnologia | Versão | Descrição |
|------------|--------|-----------|
| **C#** | 7.3 | Linguagem de programação |
| **.NET Framework** | 4.8 | Framework base |
| **Windows Forms** | - | Interface gráfica |
| **Svg (NuGet)** | 3.4.7 | Biblioteca de processamento SVG |
| **System.Drawing** | - | Manipulação de imagens |

### Dependências NuGet

```xml
<package id="Svg" version="3.4.7" targetFramework="net48" />
<package id="ExCSS" version="4.2.3" targetFramework="net48" />
<package id="System.Buffers" version="4.5.1" targetFramework="net48" />
<package id="System.Memory" version="4.5.5" targetFramework="net48" />
<package id="System.Numerics.Vectors" version="4.5.0" targetFramework="net48" />
<package id="System.Runtime.CompilerServices.Unsafe" version="4.5.3" targetFramework="net48" />
```

### Arquitetura

```
┌─────────────────────────────────────┐
│          Form1 (UI Layer)           │
│  - Interface de usuário             │
│  - Eventos de controles             │
│  - Drag & Drop                      │
└──────────────┬──────────────────────┘
               │
               ▼
┌─────────────────────────────────────┐
│     Lógica de Conversão             │
│  - Carregar SVG (Biblioteca Svg)    │
│  - Renderizar para Bitmap           │
│  - Salvar como PNG                  │
└──────────────┬──────────────────────┘
               │
               ▼
┌─────────────────────────────────────┐
│      Sistema de Ficheiros           │
│  - Pasta "Convertidos"              │
│  - Nomenclatura automática          │
│  - Gerenciamento de ficheiros       │
└─────────────────────────────────────┘
```

### Cores da Interface (Material Design)

| Elemento | Cor Hex | RGB |
|----------|---------|-----|
| Background | `#1E1E1E` | rgb(30, 30, 30) |
| Painel Drop | `#2D2D30` | rgb(45, 45, 48) |
| Botão Converter | `#007ACC` | rgb(0, 122, 204) |
| Botão Abrir | `#009900` | rgb(0, 153, 0) |
| Botão Limpar | `#B43232` | rgb(180, 50, 50) |
| Texto | `#FFFFFF` | rgb(255, 255, 255) |

---

## 🐛 Resolução de Problemas

### ❌ Erro: "O tipo Svg não pôde ser encontrado"

**Causa:** Pacote NuGet Svg não está instalado

**Solução:**
1. Abra o **Package Manager Console**
2. Execute: `Install-Package Svg`
3. Recompile o projeto (F6)

---

### ❌ Aplicação não inicia

**Causa:** Erros de compilação ou dependências ausentes

**Solução:**
1. Compile novamente (Build > Rebuild Solution)
2. Verifique a janela de erros (View > Error List)
3. Instale todas as dependências NuGet
4. Verifique se o .NET Framework 4.8 está instalado

---

### ❌ Ficheiros não convertem

**Causa:** SVG inválido ou corrompido

**Solução:**
1. Verifique se o ficheiro SVG é válido (abra num editor)
2. Teste com o ficheiro `exemplo_teste.svg` incluído
3. Simplifique o SVG se for muito complexo
4. Exporte novamente da ferramenta de origem

---

### ❌ Imagem PNG cortada

**Causa:** Proporções não mantidas ou viewBox incorreto

**Solução:**
1. Desative "Manter Proporções"
2. Ajuste manualmente largura e altura
3. Verifique o viewBox do SVG original
4. Use dimensões proporcionais ao original

---

### ❌ Cores incorretas no PNG

**Causa:** Perfis de cor específicos no SVG

**Solução:**
1. Converta para sRGB antes de exportar SVG
2. Simplifique o SVG removendo perfis de cor
3. Use outra ferramenta para exportar o SVG

---

### ❌ Pasta "Convertidos" não abre

**Causa:** Pasta não foi criada ou falta permissão

**Solução:**
1. Execute pelo menos uma conversão primeiro
2. Verifique permissões da pasta onde o EXE está
3. Execute a aplicação como Administrador se necessário

---

## 🎯 Casos de Uso

### 🎨 Design de Ícones
Crie ícones em formato vetorial (SVG) e exporte para múltiplos tamanhos PNG para usar em aplicações, websites e sistemas operacionais.

### 🏢 Logos Corporativos
Mantenha logos em SVG (editável) e gere versões PNG em diferentes tamanhos para diversos usos: impressão, web, redes sociais, etc.

### 🖼️ Assets de UI/UX
Desenhe interfaces em vetorial e exporte elementos específicos como PNG para integrar em aplicações e protótipos.

### 🌐 Recursos Web
Mantenha originais SVG para edição futura e gere PNGs otimizados para diferentes resoluções e dispositivos (responsive design).

### 📱 App Development
Gere ícones de aplicações em múltiplas resoluções necessárias para diferentes plataformas (iOS, Android, Windows, etc).

---

## 🤝 Contribuir

Contribuições são bem-vindas! Sinta-se à vontade para:

1. 🍴 Fazer fork do projeto
2. 🌿 Criar uma branch para sua feature (`git checkout -b feature/NovaFuncionalidade`)
3. 💾 Commit suas mudanças (`git commit -m 'Adiciona nova funcionalidade'`)
4. 📤 Push para a branch (`git push origin feature/NovaFuncionalidade`)
5. 🔀 Abrir um Pull Request

### Ideias para Contribuição

- ✨ Adicionar suporte para mais formatos (JPG, WebP, TIFF)
- 🎨 Melhorar a interface com novos temas
- ⚡ Otimizar performance para ficheiros grandes
- 🌍 Adicionar suporte multilíngue
- 📊 Implementar análise de qualidade das conversões
- 🔧 Adicionar configurações avançadas de exportação

---

## 📄 Licença

Este projeto está sob a licença MIT. Veja o ficheiro [LICENSE](LICENSE) para mais detalhes.

---

## 👨‍💻 Autor

**Projetos Lendários**

- GitHub: [@ProjetosLendarios](https://github.com/ProjetosLendarios)
- Repository: [ConversorSvgToPng](https://github.com/ProjetosLendarios/ConversorSvgToPng)

---

## 🙏 Agradecimentos

- [Svg Library](https://github.com/svg-net/SVG) - Biblioteca para processamento de SVG em .NET
- Comunidade .NET - Pelo suporte e recursos
- Todos os contribuidores deste projeto

---

## 📞 Suporte

Se encontrar algum problema ou tiver sugestões:

1. 🐛 [Abra uma Issue](https://github.com/ProjetosLendarios/ConversorSvgToPng/issues)
2. 💬 [Inicie uma Discussion](https://github.com/ProjetosLendarios/ConversorSvgToPng/discussions)
3. ⭐ Dê uma estrela no projeto se for útil!

---

<div align="center">

**Feito com ❤️ e C#**

⭐ Se este projeto foi útil, considere dar uma estrela!

</div>
