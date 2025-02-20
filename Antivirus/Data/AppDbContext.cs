using Antivirus.Models;
using Microsoft.EntityFrameworkCore;

namespace Antivirus.Data;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<bootcamps> bootcamps { get; set; }

    public virtual DbSet<categories_opportunities> categories_opportunities { get; set; }

    public virtual DbSet<costs_bootcamps> costs_bootcamps { get; set; }

    public virtual DbSet<descriptions_bootcamps> descriptions_bootcamps { get; set; }

    public virtual DbSet<institute_bootcamps> institute_bootcamps { get; set; }

    public virtual DbSet<institute_opportunities> institute_opportunities { get; set; }

    public virtual DbSet<institutions> institutions { get; set; }

    public virtual DbSet<opportunities> opportunities { get; set; }

    public virtual DbSet<role> role { get; set; }

    public virtual DbSet<status_bootcamps> status_bootcamps { get; set; }

    public virtual DbSet<status_institutions> status_institutions { get; set; }

    public virtual DbSet<status_opportunities> status_opportunities { get; set; }

    public virtual DbSet<topics_bootcamps> topics_bootcamps { get; set; }

    public virtual DbSet<type_opportunities> type_opportunities { get; set; }

    public virtual DbSet<ubications_institutions> ubications_institutions { get; set; }

    public virtual DbSet<user_oportunities> user_oportunities { get; set; }

    public virtual DbSet<user_roles> user_roles { get; set; }

    public virtual DbSet<users> users { get; set; }

    public virtual DbSet<users_bootcamps> users_bootcamps { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost; Database=dbAntivirus; Username=postgres;password=12345");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<bootcamps>(entity =>
        {
            entity.HasKey(e => e.id).HasName("pk_bootcamps");

            entity.HasOne(d => d.id_costos).WithMany(p => p.bootcamps).HasConstraintName("fk9xuiavb96354u5fyqqgdidje2");

            entity.HasOne(d => d.id_estado).WithMany(p => p.bootcamps).HasConstraintName("fkf0hwerqfhhpsjsg0hyp6t9xay");

            entity.HasOne(d => d.id_general).WithMany(p => p.bootcamps).HasConstraintName("fkjv4fduf6dkh5gp1gy6k9uyngw");

            entity.HasOne(d => d.id_temas).WithMany(p => p.bootcamps).HasConstraintName("fkqw8goqpav8guq2u2dp06l9fco");
        });

        modelBuilder.Entity<categories_opportunities>(entity =>
        {
            entity.HasKey(e => e.id).HasName("pk_categories_opportunities");
        });

        modelBuilder.Entity<costs_bootcamps>(entity =>
        {
            entity.HasKey(e => e.id).HasName("pk_costs_bootcamps");
        });

        modelBuilder.Entity<descriptions_bootcamps>(entity =>
        {
            entity.HasKey(e => e.id).HasName("pk_descriptions_bootcamps");
        });

        modelBuilder.Entity<institute_bootcamps>(entity =>
        {
            entity.HasKey(e => e.id).HasName("pk_institute_bootcamps");

            entity.HasOne(d => d.id_bootcampsNavigation).WithMany(p => p.institute_bootcamps).HasConstraintName("fkibgmi914ixp8n15q6r98e35j0");

            entity.HasOne(d => d.id_institutionsNavigation).WithMany(p => p.institute_bootcamps).HasConstraintName("fk94xtqb83b39kr2eg5ruccm5bo");
        });

        modelBuilder.Entity<institute_opportunities>(entity =>
        {
            entity.HasKey(e => e.id).HasName("pk_institute_opportunities");

            entity.HasOne(d => d.id_institutionsNavigation).WithMany(p => p.institute_opportunities).HasConstraintName("fkford1un3y2i3d2u784xukenqy");

            entity.HasOne(d => d.id_opportunitiesNavigation).WithMany(p => p.institute_opportunities).HasConstraintName("fkmfll2parmn67irst86mw41kih");
        });

        modelBuilder.Entity<institutions>(entity =>
        {
            entity.HasKey(e => e.id).HasName("pk_institutions");

            entity.HasOne(d => d.id_statusNavigation).WithMany(p => p.institutions).HasConstraintName("fk8eogasiuqctsewhguwkwkcd60");

            entity.HasOne(d => d.ubications_institutionsNavigation).WithMany(p => p.institutions).HasConstraintName("fk5as0aeai7nx6n5vgarqharpal");
        });

        modelBuilder.Entity<opportunities>(entity =>
        {
            entity.HasKey(e => e.id).HasName("pk_opportunities");

            entity.HasOne(d => d.id_categoriesNavigation).WithMany(p => p.opportunities).HasConstraintName("fkh9cuofel5n7uyh82ktwnbh1c7");

            entity.HasOne(d => d.id_status_reviewNavigation).WithMany(p => p.opportunities).HasConstraintName("fkfalcps2a9hij52b0ho66hfvme");

            entity.HasOne(d => d.oportunity_typeNavigation).WithMany(p => p.opportunities).HasConstraintName("fklnmbgi82s4mmp6sxi0v09jr8n");
        });

        modelBuilder.Entity<role>(entity =>
        {
            entity.HasKey(e => e.id).HasName("pk_role");
        });

        modelBuilder.Entity<status_bootcamps>(entity =>
        {
            entity.HasKey(e => e.id).HasName("pk_status_bootcamps");
        });

        modelBuilder.Entity<status_institutions>(entity =>
        {
            entity.HasKey(e => e.id).HasName("pk_status_institutions");
        });

        modelBuilder.Entity<status_opportunities>(entity =>
        {
            entity.HasKey(e => e.id).HasName("pk_status_opportunities");
        });

        modelBuilder.Entity<topics_bootcamps>(entity =>
        {
            entity.HasKey(e => e.id).HasName("pk_topics_bootcamps");
        });

        modelBuilder.Entity<type_opportunities>(entity =>
        {
            entity.HasKey(e => e.id).HasName("pk_type_opportunities");
        });

        modelBuilder.Entity<ubications_institutions>(entity =>
        {
            entity.HasKey(e => e.id).HasName("pk_ubications_institutions");
        });

        modelBuilder.Entity<user_oportunities>(entity =>
        {
            entity.HasKey(e => e.id).HasName("pk_user_oportunities");

            entity.HasOne(d => d.id_opportunityNavigation).WithMany(p => p.user_oportunities).HasConstraintName("fk38p2dg6rit712540p57c2pe67");

            entity.HasOne(d => d.id_userNavigation).WithMany(p => p.user_oportunities).HasConstraintName("fknx8chpjucnvb00t8rpc77dcpk");
        });

        modelBuilder.Entity<user_roles>(entity =>
        {
            entity.HasKey(e => new { e.users_id, e.role_id }).HasName("pk_user_roles");

            entity.HasOne(d => d.role).WithMany(p => p.user_roles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fkrhfovtciq1l558cw6udg0h0d3");

            entity.HasOne(d => d.users).WithMany(p => p.user_roles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fkoovdgg7vvr1hb8vw6ivcrv3tb");
        });

        modelBuilder.Entity<users>(entity =>
        {
            entity.HasKey(e => e.id).HasName("pk_users");
        });

        modelBuilder.Entity<users_bootcamps>(entity =>
        {
            entity.HasKey(e => e.id).HasName("pk_users bootcamps");

            entity.HasOne(d => d.id_bootcampNavigation).WithMany(p => p.users_bootcamps).HasConstraintName("fkqp5qxld9th4l8mwfymb9ttjpa");

            entity.HasOne(d => d.id_usuarioNavigation).WithMany(p => p.users_bootcamps).HasConstraintName("fk1psvppbmh5hflxjklfhljc885");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
