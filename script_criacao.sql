USE [clinica_veterinaria]
GO
/****** Object:  Table [dbo].[animais]    Script Date: 04/11/2021 11:39:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[animais](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[cliente_id] [int] NOT NULL,
	[tipo_animal] [int] NOT NULL,
	[nome] [varchar](45) NOT NULL,
	[data_nascimento] [date] NULL,
	[pelagem] [varchar](45) NULL,
	[sexo] [bit] NOT NULL,
	[status] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[animais_tipo]    Script Date: 04/11/2021 11:39:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[animais_tipo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descricao] [varchar](60) NOT NULL,
	[status] [bit] NOT NULL,
 CONSTRAINT [PK__animais___3213E83F36B7A5EF] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[categorias_produtos]    Script Date: 04/11/2021 11:39:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[categorias_produtos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descricao] [varchar](60) NOT NULL,
	[tipo_produto] [bit] NOT NULL,
	[status] [bit] NOT NULL,
 CONSTRAINT [PK__categori__3213E83F26FE9C52] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[clientes]    Script Date: 04/11/2021 11:39:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clientes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](45) NOT NULL,
	[sobrenome] [varchar](45) NOT NULL,
	[cpf] [char](11) NULL,
	[rg] [char](9) NULL,
	[telefone] [varchar](12) NULL,
	[email] [varchar](100) NULL,
	[end_logradouro] [varchar](50) NULL,
	[end_numero] [int] NULL,
	[end_bairro] [varchar](30) NULL,
	[end_cidade] [varchar](30) NULL,
	[end_cep] [char](8) NULL,
	[end_estado] [int] NULL,
	[data_cadastro] [date] NOT NULL,
	[status] [bit] NULL,
 CONSTRAINT [PK__clientes__3213E83F543028B4] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[compras]    Script Date: 04/11/2021 11:39:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[compras](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[funcionario_id] [int] NOT NULL,
	[fornecedor_id] [int] NOT NULL,
	[data_compra] [datetime] NOT NULL,
	[valor_total] [varchar](45) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[compras_pagamentos]    Script Date: 04/11/2021 11:39:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[compras_pagamentos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[forma_pagamento_id] [int] NOT NULL,
	[valor_pago] [decimal](10, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[compras_produtos]    Script Date: 04/11/2021 11:39:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[compras_produtos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[produto_id] [int] NOT NULL,
	[valor_unitario] [decimal](10, 2) NOT NULL,
	[quantidade] [decimal](8, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[formas_pagamento]    Script Date: 04/11/2021 11:39:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[formas_pagamento](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descricao] [varchar](60) NOT NULL,
	[status] [bit] NOT NULL,
 CONSTRAINT [PK__formas_p__3213E83FF85E913A] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[fornecedores]    Script Date: 04/11/2021 11:39:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[fornecedores](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[razao_social] [varchar](80) NOT NULL,
	[nome_fantasia] [varchar](80) NOT NULL,
	[cnpj] [char](14) NOT NULL,
	[inscricao_estadual] [char](12) NOT NULL,
	[telefone] [varchar](12) NOT NULL,
	[email] [varchar](100) NOT NULL,
	[end_logradouro] [varchar](45) NOT NULL,
	[end_numero] [varchar](10) NOT NULL,
	[end_bairro] [varchar](45) NOT NULL,
	[end_cidade] [varchar](45) NOT NULL,
	[end_cep] [varchar](8) NOT NULL,
	[end_estado] [int] NOT NULL,
	[status] [bit] NOT NULL,
 CONSTRAINT [PK__forneced__3213E83F5EA7957D] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[funcionarios]    Script Date: 04/11/2021 11:39:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[funcionarios](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[funcao_id] [int] NOT NULL,
	[tipo] [bit] NOT NULL,
	[nome_completo] [varchar](70) NOT NULL,
	[usuario] [varchar](30) NOT NULL,
	[senha] [varchar](16) NOT NULL,
	[data_cadastro] [date] NOT NULL,
	[status] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[funcionarios_funcoes]    Script Date: 04/11/2021 11:39:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[funcionarios_funcoes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descricao] [varchar](60) NOT NULL,
	[status] [bit] NOT NULL,
 CONSTRAINT [PK__funciona__3213E83F61601BAE] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[produtos]    Script Date: 04/11/2021 11:39:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[produtos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fornecedor_id] [int] NOT NULL,
	[tipo] [bit] NOT NULL,
	[descricao] [varchar](70) NOT NULL,
	[valor] [decimal](10, 2) NOT NULL,
	[categoria_id] [int] NOT NULL,
	[un_medida_id] [int] NOT NULL,
	[funcionario_tipo_id] [int] NOT NULL,
	[status] [bit] NOT NULL,
 CONSTRAINT [PK__produtos__3213E83F6B325B85] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[servicos]    Script Date: 04/11/2021 11:39:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[servicos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[produto_id] [int] NOT NULL,
	[animal_id] [int] NOT NULL,
	[funcionario_id] [int] NOT NULL,
	[data_inicio] [datetime] NOT NULL,
	[data_fim] [datetime] NULL,
	[valor] [decimal](10, 2) NOT NULL,
	[observacao] [text] NOT NULL,
	[status] [bit] NOT NULL,
	[data_criacao] [datetime] NOT NULL,
	[atendente_id] [int] NOT NULL,
	[cliente_id] [int] NOT NULL,
 CONSTRAINT [PK__servicos__3213E83F9C8FCAC3] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[unidade_medida]    Script Date: 04/11/2021 11:39:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[unidade_medida](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fracionavel] [bit] NOT NULL,
	[descricao] [varchar](60) NOT NULL,
	[status] [bit] NOT NULL,
 CONSTRAINT [PK__unidade___3213E83F7610F038] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[vendas]    Script Date: 04/11/2021 11:39:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vendas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[vendedor_id] [int] NULL,
	[valor_total] [decimal](10, 2) NULL,
	[data_emissao] [varchar](45) NULL,
	[observacoes] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[vendas_pagamentos]    Script Date: 04/11/2021 11:39:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vendas_pagamentos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[venda_id] [int] NOT NULL,
	[forma_pagamento_id] [int] NOT NULL,
	[valor_pago] [decimal](10, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[vendas_produtos]    Script Date: 04/11/2021 11:39:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vendas_produtos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[venda_id] [int] NOT NULL,
	[produto_id] [int] NOT NULL,
	[quantidade] [decimal](8, 3) NOT NULL,
	[valor_unitario] [decimal](10, 3) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[funcionarios] ON 

INSERT [dbo].[funcionarios] ([id], [funcao_id], [tipo], [nome_completo], [usuario], [senha], [data_cadastro], [status]) VALUES (1, 1, 1, N'Usuáio Admin', N'Admin', N'admin', CAST(N'2021-11-04' AS Date), 1)
INSERT [dbo].[funcionarios] ([id], [funcao_id], [tipo], [nome_completo], [usuario], [senha], [data_cadastro], [status]) VALUES (2, 2, 0, N'Operador', N'Operador', N'operador', CAST(N'2021-11-04' AS Date), 1)
SET IDENTITY_INSERT [dbo].[funcionarios] OFF
GO
SET IDENTITY_INSERT [dbo].[funcionarios_funcoes] ON 

INSERT [dbo].[funcionarios_funcoes] ([id], [descricao], [status]) VALUES (1, N'Admin', 1)
INSERT [dbo].[funcionarios_funcoes] ([id], [descricao], [status]) VALUES (2, N'Operador', 1)
SET IDENTITY_INSERT [dbo].[funcionarios_funcoes] OFF
GO
ALTER TABLE [dbo].[animais] ADD  DEFAULT (NULL) FOR [data_nascimento]
GO
ALTER TABLE [dbo].[animais] ADD  DEFAULT (NULL) FOR [pelagem]
GO
ALTER TABLE [dbo].[animais] ADD  DEFAULT ((0)) FOR [sexo]
GO
ALTER TABLE [dbo].[animais] ADD  DEFAULT ((1)) FOR [status]
GO
ALTER TABLE [dbo].[animais_tipo] ADD  CONSTRAINT [DF__animais_t__statu__282DF8C2]  DEFAULT ((1)) FOR [status]
GO
ALTER TABLE [dbo].[categorias_produtos] ADD  CONSTRAINT [DF_categorias_produtos_tipo_produto]  DEFAULT ((1)) FOR [tipo_produto]
GO
ALTER TABLE [dbo].[categorias_produtos] ADD  CONSTRAINT [DF_categorias_produtos_status]  DEFAULT ((1)) FOR [status]
GO
ALTER TABLE [dbo].[clientes] ADD  CONSTRAINT [DF__clientes__cpf__3E52440B]  DEFAULT (NULL) FOR [cpf]
GO
ALTER TABLE [dbo].[clientes] ADD  CONSTRAINT [DF__clientes__rg__3F466844]  DEFAULT (NULL) FOR [rg]
GO
ALTER TABLE [dbo].[clientes] ADD  CONSTRAINT [DF__clientes__telefo__403A8C7D]  DEFAULT (NULL) FOR [telefone]
GO
ALTER TABLE [dbo].[clientes] ADD  CONSTRAINT [DF__clientes__email__412EB0B6]  DEFAULT (NULL) FOR [email]
GO
ALTER TABLE [dbo].[clientes] ADD  CONSTRAINT [DF__clientes__end_lo__4222D4EF]  DEFAULT (NULL) FOR [end_logradouro]
GO
ALTER TABLE [dbo].[clientes] ADD  CONSTRAINT [DF__clientes__end_nu__4316F928]  DEFAULT (NULL) FOR [end_numero]
GO
ALTER TABLE [dbo].[clientes] ADD  CONSTRAINT [DF__clientes__end_ba__440B1D61]  DEFAULT (NULL) FOR [end_bairro]
GO
ALTER TABLE [dbo].[clientes] ADD  CONSTRAINT [DF__clientes__end_ci__44FF419A]  DEFAULT (NULL) FOR [end_cidade]
GO
ALTER TABLE [dbo].[clientes] ADD  CONSTRAINT [DF__clientes__end_ce__45F365D3]  DEFAULT (NULL) FOR [end_cep]
GO
ALTER TABLE [dbo].[clientes] ADD  CONSTRAINT [DF__clientes__end_es__46E78A0C]  DEFAULT (NULL) FOR [end_estado]
GO
ALTER TABLE [dbo].[clientes] ADD  CONSTRAINT [DF__clientes__status__47DBAE45]  DEFAULT ((1)) FOR [status]
GO
ALTER TABLE [dbo].[compras_pagamentos] ADD  DEFAULT ((0.00)) FOR [valor_pago]
GO
ALTER TABLE [dbo].[compras_produtos] ADD  DEFAULT ((0.00)) FOR [valor_unitario]
GO
ALTER TABLE [dbo].[formas_pagamento] ADD  CONSTRAINT [df_frm_pgto_status]  DEFAULT ((1)) FOR [status]
GO
ALTER TABLE [dbo].[fornecedores] ADD  CONSTRAINT [DF__fornecedo__nome___5535A963]  DEFAULT (NULL) FOR [nome_fantasia]
GO
ALTER TABLE [dbo].[fornecedores] ADD  CONSTRAINT [DF__fornecedo__inscr__5629CD9C]  DEFAULT (NULL) FOR [inscricao_estadual]
GO
ALTER TABLE [dbo].[fornecedores] ADD  CONSTRAINT [DF__fornecedo__telef__571DF1D5]  DEFAULT (NULL) FOR [telefone]
GO
ALTER TABLE [dbo].[fornecedores] ADD  CONSTRAINT [DF__fornecedo__email__5812160E]  DEFAULT (NULL) FOR [email]
GO
ALTER TABLE [dbo].[fornecedores] ADD  CONSTRAINT [DF__fornecedo__end_l__59063A47]  DEFAULT (NULL) FOR [end_logradouro]
GO
ALTER TABLE [dbo].[fornecedores] ADD  CONSTRAINT [DF__fornecedo__end_n__59FA5E80]  DEFAULT (NULL) FOR [end_numero]
GO
ALTER TABLE [dbo].[fornecedores] ADD  CONSTRAINT [DF__fornecedo__end_b__5AEE82B9]  DEFAULT (NULL) FOR [end_bairro]
GO
ALTER TABLE [dbo].[fornecedores] ADD  CONSTRAINT [DF__fornecedo__end_c__5BE2A6F2]  DEFAULT (NULL) FOR [end_cidade]
GO
ALTER TABLE [dbo].[fornecedores] ADD  CONSTRAINT [DF__fornecedo__end_c__5CD6CB2B]  DEFAULT (NULL) FOR [end_cep]
GO
ALTER TABLE [dbo].[fornecedores] ADD  CONSTRAINT [DF__fornecedo__end_e__5DCAEF64]  DEFAULT (NULL) FOR [end_estado]
GO
ALTER TABLE [dbo].[fornecedores] ADD  CONSTRAINT [DF__fornecedo__statu__5EBF139D]  DEFAULT (NULL) FOR [status]
GO
ALTER TABLE [dbo].[funcionarios] ADD  DEFAULT ((0)) FOR [tipo]
GO
ALTER TABLE [dbo].[funcionarios] ADD  CONSTRAINT [DF_funcionarios_status]  DEFAULT ((1)) FOR [status]
GO
ALTER TABLE [dbo].[funcionarios_funcoes] ADD  CONSTRAINT [DF_funcionarios_funcoes_status]  DEFAULT ((0)) FOR [status]
GO
ALTER TABLE [dbo].[produtos] ADD  CONSTRAINT [DF__produtos__fornec__66603565]  DEFAULT ((0)) FOR [fornecedor_id]
GO
ALTER TABLE [dbo].[produtos] ADD  CONSTRAINT [DF__produtos__tipo__6754599E]  DEFAULT ((0)) FOR [tipo]
GO
ALTER TABLE [dbo].[produtos] ADD  CONSTRAINT [DF__produtos__valor__68487DD7]  DEFAULT ((0.00)) FOR [valor]
GO
ALTER TABLE [dbo].[produtos] ADD  CONSTRAINT [DF_produtos_status]  DEFAULT ((1)) FOR [status]
GO
ALTER TABLE [dbo].[servicos] ADD  CONSTRAINT [DF__servicos__data_f__6B24EA82]  DEFAULT (NULL) FOR [data_fim]
GO
ALTER TABLE [dbo].[servicos] ADD  CONSTRAINT [DF__servicos__valor__6C190EBB]  DEFAULT ((0.00)) FOR [valor]
GO
ALTER TABLE [dbo].[servicos] ADD  CONSTRAINT [DF__servicos__status__6D0D32F4]  DEFAULT ((0)) FOR [status]
GO
ALTER TABLE [dbo].[servicos] ADD  CONSTRAINT [DF_servicos_cliente_id]  DEFAULT ((0)) FOR [cliente_id]
GO
ALTER TABLE [dbo].[unidade_medida] ADD  CONSTRAINT [DF_unidade_medida_fracionavel]  DEFAULT ((0)) FOR [fracionavel]
GO
ALTER TABLE [dbo].[unidade_medida] ADD  CONSTRAINT [DF__unidade_m__statu__29221CFB]  DEFAULT ((1)) FOR [status]
GO
ALTER TABLE [dbo].[vendas] ADD  DEFAULT (NULL) FOR [vendedor_id]
GO
ALTER TABLE [dbo].[vendas] ADD  DEFAULT ((0.00)) FOR [valor_total]
GO
ALTER TABLE [dbo].[vendas] ADD  DEFAULT (NULL) FOR [data_emissao]
GO
ALTER TABLE [dbo].[vendas_pagamentos] ADD  DEFAULT ((0.00)) FOR [valor_pago]
GO
ALTER TABLE [dbo].[vendas_produtos] ADD  DEFAULT ((1.000)) FOR [quantidade]
GO
ALTER TABLE [dbo].[vendas_produtos] ADD  DEFAULT ((0.000)) FOR [valor_unitario]
GO
ALTER TABLE [dbo].[animais]  WITH CHECK ADD  CONSTRAINT [fk_animal_cliente_id] FOREIGN KEY([cliente_id])
REFERENCES [dbo].[clientes] ([id])
GO
ALTER TABLE [dbo].[animais] CHECK CONSTRAINT [fk_animal_cliente_id]
GO
ALTER TABLE [dbo].[animais]  WITH CHECK ADD  CONSTRAINT [fk_animal_tipo_id] FOREIGN KEY([tipo_animal])
REFERENCES [dbo].[animais_tipo] ([id])
GO
ALTER TABLE [dbo].[animais] CHECK CONSTRAINT [fk_animal_tipo_id]
GO
ALTER TABLE [dbo].[compras]  WITH CHECK ADD  CONSTRAINT [fk_compras_fornecedor_id] FOREIGN KEY([fornecedor_id])
REFERENCES [dbo].[fornecedores] ([id])
GO
ALTER TABLE [dbo].[compras] CHECK CONSTRAINT [fk_compras_fornecedor_id]
GO
ALTER TABLE [dbo].[compras]  WITH CHECK ADD  CONSTRAINT [fk_compras_funcionario_id] FOREIGN KEY([funcionario_id])
REFERENCES [dbo].[fornecedores] ([id])
GO
ALTER TABLE [dbo].[compras] CHECK CONSTRAINT [fk_compras_funcionario_id]
GO
ALTER TABLE [dbo].[compras_pagamentos]  WITH CHECK ADD  CONSTRAINT [fk_compras_forma_pagamento_id] FOREIGN KEY([forma_pagamento_id])
REFERENCES [dbo].[formas_pagamento] ([id])
GO
ALTER TABLE [dbo].[compras_pagamentos] CHECK CONSTRAINT [fk_compras_forma_pagamento_id]
GO
ALTER TABLE [dbo].[compras_produtos]  WITH CHECK ADD  CONSTRAINT [fk_compras_produto_id] FOREIGN KEY([produto_id])
REFERENCES [dbo].[produtos] ([id])
GO
ALTER TABLE [dbo].[compras_produtos] CHECK CONSTRAINT [fk_compras_produto_id]
GO
ALTER TABLE [dbo].[funcionarios]  WITH CHECK ADD  CONSTRAINT [fk_funcionario_funcao_id] FOREIGN KEY([funcao_id])
REFERENCES [dbo].[funcionarios_funcoes] ([id])
GO
ALTER TABLE [dbo].[funcionarios] CHECK CONSTRAINT [fk_funcionario_funcao_id]
GO
ALTER TABLE [dbo].[produtos]  WITH CHECK ADD  CONSTRAINT [fk_produto_categoria_id] FOREIGN KEY([categoria_id])
REFERENCES [dbo].[categorias_produtos] ([id])
GO
ALTER TABLE [dbo].[produtos] CHECK CONSTRAINT [fk_produto_categoria_id]
GO
ALTER TABLE [dbo].[produtos]  WITH CHECK ADD  CONSTRAINT [fk_produto_fornecedor_id] FOREIGN KEY([fornecedor_id])
REFERENCES [dbo].[fornecedores] ([id])
GO
ALTER TABLE [dbo].[produtos] CHECK CONSTRAINT [fk_produto_fornecedor_id]
GO
ALTER TABLE [dbo].[produtos]  WITH CHECK ADD  CONSTRAINT [fk_produto_funcionario_tipo_id] FOREIGN KEY([funcionario_tipo_id])
REFERENCES [dbo].[funcionarios_funcoes] ([id])
GO
ALTER TABLE [dbo].[produtos] CHECK CONSTRAINT [fk_produto_funcionario_tipo_id]
GO
ALTER TABLE [dbo].[produtos]  WITH CHECK ADD  CONSTRAINT [fk_produto_un_medida] FOREIGN KEY([un_medida_id])
REFERENCES [dbo].[unidade_medida] ([id])
GO
ALTER TABLE [dbo].[produtos] CHECK CONSTRAINT [fk_produto_un_medida]
GO
ALTER TABLE [dbo].[servicos]  WITH CHECK ADD  CONSTRAINT [fk_servico_animal_id] FOREIGN KEY([animal_id])
REFERENCES [dbo].[animais] ([id])
GO
ALTER TABLE [dbo].[servicos] CHECK CONSTRAINT [fk_servico_animal_id]
GO
ALTER TABLE [dbo].[servicos]  WITH CHECK ADD  CONSTRAINT [fk_servico_cliente_id] FOREIGN KEY([cliente_id])
REFERENCES [dbo].[clientes] ([id])
GO
ALTER TABLE [dbo].[servicos] CHECK CONSTRAINT [fk_servico_cliente_id]
GO
ALTER TABLE [dbo].[servicos]  WITH CHECK ADD  CONSTRAINT [fk_servico_funcionario_id] FOREIGN KEY([funcionario_id])
REFERENCES [dbo].[funcionarios] ([id])
GO
ALTER TABLE [dbo].[servicos] CHECK CONSTRAINT [fk_servico_funcionario_id]
GO
ALTER TABLE [dbo].[servicos]  WITH CHECK ADD  CONSTRAINT [fk_servico_produto_id] FOREIGN KEY([produto_id])
REFERENCES [dbo].[produtos] ([id])
GO
ALTER TABLE [dbo].[servicos] CHECK CONSTRAINT [fk_servico_produto_id]
GO
ALTER TABLE [dbo].[servicos]  WITH CHECK ADD  CONSTRAINT [fk_servicos_atendente_id] FOREIGN KEY([atendente_id])
REFERENCES [dbo].[funcionarios] ([id])
GO
ALTER TABLE [dbo].[servicos] CHECK CONSTRAINT [fk_servicos_atendente_id]
GO
ALTER TABLE [dbo].[vendas]  WITH CHECK ADD  CONSTRAINT [fk_venda_vendedor_id] FOREIGN KEY([vendedor_id])
REFERENCES [dbo].[funcionarios] ([id])
GO
ALTER TABLE [dbo].[vendas] CHECK CONSTRAINT [fk_venda_vendedor_id]
GO
ALTER TABLE [dbo].[vendas_pagamentos]  WITH CHECK ADD  CONSTRAINT [fk_pagamentos_venda_id] FOREIGN KEY([venda_id])
REFERENCES [dbo].[vendas] ([id])
GO
ALTER TABLE [dbo].[vendas_pagamentos] CHECK CONSTRAINT [fk_pagamentos_venda_id]
GO
ALTER TABLE [dbo].[vendas_pagamentos]  WITH CHECK ADD  CONSTRAINT [fk_venda_forma_pagamento_id] FOREIGN KEY([venda_id])
REFERENCES [dbo].[formas_pagamento] ([id])
GO
ALTER TABLE [dbo].[vendas_pagamentos] CHECK CONSTRAINT [fk_venda_forma_pagamento_id]
GO
ALTER TABLE [dbo].[vendas_produtos]  WITH CHECK ADD  CONSTRAINT [fk_produto_id] FOREIGN KEY([produto_id])
REFERENCES [dbo].[produtos] ([id])
GO
ALTER TABLE [dbo].[vendas_produtos] CHECK CONSTRAINT [fk_produto_id]
GO
ALTER TABLE [dbo].[vendas_produtos]  WITH CHECK ADD  CONSTRAINT [fk_produtos_venda_id] FOREIGN KEY([venda_id])
REFERENCES [dbo].[vendas] ([id])
GO
ALTER TABLE [dbo].[vendas_produtos] CHECK CONSTRAINT [fk_produtos_venda_id]
GO
