using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Antivirus.Migrations
{
    /// <inheritdoc />
    public partial class AddingJwt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categories_opportunities",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    categories = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    trial751 = table.Column<char>(type: "character(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_categories_opportunities", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "costs_bootcamps",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    costs = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    trial751 = table.Column<char>(type: "character(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_costs_bootcamps", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "descriptions_bootcamps",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    description = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    trial751 = table.Column<char>(type: "character(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_descriptions_bootcamps", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "role",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    trial755 = table.Column<char>(type: "character(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_role", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "status_bootcamps",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    status = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    trial751 = table.Column<char>(type: "character(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_status_bootcamps", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "status_institutions",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    status_review = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    trial751 = table.Column<char>(type: "character(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_status_institutions", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "status_opportunities",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    status = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    trial755 = table.Column<char>(type: "character(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_status_opportunities", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "topics_bootcamps",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    topics = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    trial751 = table.Column<char>(type: "character(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_topics_bootcamps", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "type_opportunities",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    oportunity_type = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    trial755 = table.Column<char>(type: "character(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_type_opportunities", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ubications_institutions",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    zona = table.Column<string>(type: "character varying(144)", maxLength: 144, nullable: true),
                    trial751 = table.Column<char>(type: "character(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ubications_institutions", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    date_birth = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    email = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    last_name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    password = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    trial755 = table.Column<char>(type: "character(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "bootcamps",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    id_costos_id = table.Column<long>(type: "bigint", nullable: true),
                    id_estado_id = table.Column<long>(type: "bigint", nullable: true),
                    id_general_id = table.Column<long>(type: "bigint", nullable: true),
                    id_temas_id = table.Column<long>(type: "bigint", nullable: true),
                    informacion = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    trial751 = table.Column<char>(type: "character(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_bootcamps", x => x.id);
                    table.ForeignKey(
                        name: "fk9xuiavb96354u5fyqqgdidje2",
                        column: x => x.id_costos_id,
                        principalTable: "costs_bootcamps",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkf0hwerqfhhpsjsg0hyp6t9xay",
                        column: x => x.id_estado_id,
                        principalTable: "status_bootcamps",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkjv4fduf6dkh5gp1gy6k9uyngw",
                        column: x => x.id_general_id,
                        principalTable: "descriptions_bootcamps",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkqw8goqpav8guq2u2dp06l9fco",
                        column: x => x.id_temas_id,
                        principalTable: "topics_bootcamps",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "opportunities",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    adicional_dates = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    applications = table.Column<string>(type: "character varying(144)", maxLength: 144, nullable: true),
                    contact_channels = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    descriptions = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    guide = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    observations = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    requeriments = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    id_categories = table.Column<long>(type: "bigint", nullable: true),
                    id_status_review = table.Column<long>(type: "bigint", nullable: true),
                    oportunity_type = table.Column<long>(type: "bigint", nullable: true),
                    trial755 = table.Column<char>(type: "character(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_opportunities", x => x.id);
                    table.ForeignKey(
                        name: "fkfalcps2a9hij52b0ho66hfvme",
                        column: x => x.id_status_review,
                        principalTable: "status_opportunities",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkh9cuofel5n7uyh82ktwnbh1c7",
                        column: x => x.id_categories,
                        principalTable: "categories_opportunities",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fklnmbgi82s4mmp6sxi0v09jr8n",
                        column: x => x.oportunity_type,
                        principalTable: "type_opportunities",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "institutions",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    bienestar_link = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    carer_link = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    directions = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    general_link = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    procces_link = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    id_status = table.Column<long>(type: "bigint", nullable: true),
                    ubications_institutions = table.Column<long>(type: "bigint", nullable: true),
                    name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    observations = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    trial751 = table.Column<char>(type: "character(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_institutions", x => x.id);
                    table.ForeignKey(
                        name: "fk5as0aeai7nx6n5vgarqharpal",
                        column: x => x.ubications_institutions,
                        principalTable: "ubications_institutions",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk8eogasiuqctsewhguwkwkcd60",
                        column: x => x.id_status,
                        principalTable: "status_institutions",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "user_roles",
                columns: table => new
                {
                    users_id = table.Column<long>(type: "bigint", nullable: false),
                    role_id = table.Column<long>(type: "bigint", nullable: false),
                    trial755 = table.Column<char>(type: "character(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_user_roles", x => new { x.users_id, x.role_id });
                    table.ForeignKey(
                        name: "fkoovdgg7vvr1hb8vw6ivcrv3tb",
                        column: x => x.users_id,
                        principalTable: "users",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkrhfovtciq1l558cw6udg0h0d3",
                        column: x => x.role_id,
                        principalTable: "role",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "users bootcamps",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    id_bootcamp = table.Column<long>(type: "bigint", nullable: true),
                    id_usuario = table.Column<long>(type: "bigint", nullable: true),
                    trial755 = table.Column<char>(type: "character(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_users bootcamps", x => x.id);
                    table.ForeignKey(
                        name: "fk1psvppbmh5hflxjklfhljc885",
                        column: x => x.id_usuario,
                        principalTable: "users",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkqp5qxld9th4l8mwfymb9ttjpa",
                        column: x => x.id_bootcamp,
                        principalTable: "bootcamps",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "user_oportunities",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    id_opportunity = table.Column<long>(type: "bigint", nullable: true),
                    id_user = table.Column<long>(type: "bigint", nullable: true),
                    trial755 = table.Column<char>(type: "character(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_user_oportunities", x => x.id);
                    table.ForeignKey(
                        name: "fk38p2dg6rit712540p57c2pe67",
                        column: x => x.id_opportunity,
                        principalTable: "opportunities",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fknx8chpjucnvb00t8rpc77dcpk",
                        column: x => x.id_user,
                        principalTable: "users",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "institute_bootcamps",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    id_bootcamps = table.Column<long>(type: "bigint", nullable: true),
                    id_institutions = table.Column<long>(type: "bigint", nullable: true),
                    trial755 = table.Column<char>(type: "character(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_institute_bootcamps", x => x.id);
                    table.ForeignKey(
                        name: "fk94xtqb83b39kr2eg5ruccm5bo",
                        column: x => x.id_institutions,
                        principalTable: "institutions",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkibgmi914ixp8n15q6r98e35j0",
                        column: x => x.id_bootcamps,
                        principalTable: "bootcamps",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "institute_opportunities",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    id_institutions = table.Column<long>(type: "bigint", nullable: true),
                    id_opportunities = table.Column<long>(type: "bigint", nullable: true),
                    trial755 = table.Column<char>(type: "character(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_institute_opportunities", x => x.id);
                    table.ForeignKey(
                        name: "fkford1un3y2i3d2u784xukenqy",
                        column: x => x.id_institutions,
                        principalTable: "institutions",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkmfll2parmn67irst86mw41kih",
                        column: x => x.id_opportunities,
                        principalTable: "opportunities",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_bootcamps_id_costos_id",
                table: "bootcamps",
                column: "id_costos_id");

            migrationBuilder.CreateIndex(
                name: "IX_bootcamps_id_estado_id",
                table: "bootcamps",
                column: "id_estado_id");

            migrationBuilder.CreateIndex(
                name: "IX_bootcamps_id_general_id",
                table: "bootcamps",
                column: "id_general_id");

            migrationBuilder.CreateIndex(
                name: "IX_bootcamps_id_temas_id",
                table: "bootcamps",
                column: "id_temas_id");

            migrationBuilder.CreateIndex(
                name: "IX_institute_bootcamps_id_bootcamps",
                table: "institute_bootcamps",
                column: "id_bootcamps");

            migrationBuilder.CreateIndex(
                name: "IX_institute_bootcamps_id_institutions",
                table: "institute_bootcamps",
                column: "id_institutions");

            migrationBuilder.CreateIndex(
                name: "IX_institute_opportunities_id_institutions",
                table: "institute_opportunities",
                column: "id_institutions");

            migrationBuilder.CreateIndex(
                name: "IX_institute_opportunities_id_opportunities",
                table: "institute_opportunities",
                column: "id_opportunities");

            migrationBuilder.CreateIndex(
                name: "IX_institutions_id_status",
                table: "institutions",
                column: "id_status");

            migrationBuilder.CreateIndex(
                name: "IX_institutions_ubications_institutions",
                table: "institutions",
                column: "ubications_institutions");

            migrationBuilder.CreateIndex(
                name: "IX_opportunities_id_categories",
                table: "opportunities",
                column: "id_categories");

            migrationBuilder.CreateIndex(
                name: "IX_opportunities_id_status_review",
                table: "opportunities",
                column: "id_status_review");

            migrationBuilder.CreateIndex(
                name: "IX_opportunities_oportunity_type",
                table: "opportunities",
                column: "oportunity_type");

            migrationBuilder.CreateIndex(
                name: "IX_user_oportunities_id_opportunity",
                table: "user_oportunities",
                column: "id_opportunity");

            migrationBuilder.CreateIndex(
                name: "IX_user_oportunities_id_user",
                table: "user_oportunities",
                column: "id_user");

            migrationBuilder.CreateIndex(
                name: "IX_user_roles_role_id",
                table: "user_roles",
                column: "role_id");

            migrationBuilder.CreateIndex(
                name: "IX_users bootcamps_id_bootcamp",
                table: "users bootcamps",
                column: "id_bootcamp");

            migrationBuilder.CreateIndex(
                name: "IX_users bootcamps_id_usuario",
                table: "users bootcamps",
                column: "id_usuario");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "institute_bootcamps");

            migrationBuilder.DropTable(
                name: "institute_opportunities");

            migrationBuilder.DropTable(
                name: "user_oportunities");

            migrationBuilder.DropTable(
                name: "user_roles");

            migrationBuilder.DropTable(
                name: "users bootcamps");

            migrationBuilder.DropTable(
                name: "institutions");

            migrationBuilder.DropTable(
                name: "opportunities");

            migrationBuilder.DropTable(
                name: "role");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "bootcamps");

            migrationBuilder.DropTable(
                name: "ubications_institutions");

            migrationBuilder.DropTable(
                name: "status_institutions");

            migrationBuilder.DropTable(
                name: "status_opportunities");

            migrationBuilder.DropTable(
                name: "categories_opportunities");

            migrationBuilder.DropTable(
                name: "type_opportunities");

            migrationBuilder.DropTable(
                name: "costs_bootcamps");

            migrationBuilder.DropTable(
                name: "status_bootcamps");

            migrationBuilder.DropTable(
                name: "descriptions_bootcamps");

            migrationBuilder.DropTable(
                name: "topics_bootcamps");
        }
    }
}
