* {
    box-sizing: border-box;
}

:root {
    --bg: #f6f1ea;
    --panel: #fffdfb;
    --card: #f1e7dc;
    --text: #1e1b1a;
    --muted: #635c59;
    --accent: #a86d48;
    --accent-dark: #6d4027;
    --olive: #8b9071;
    --border: rgba(30, 27, 26, 0.09);
    --shadow: 0 20px 45px rgba(28, 20, 15, 0.08);
}

html {
    scroll-behavior: smooth;
}

body {
    margin: 0;
    background: var(--bg);
    color: var(--text);
    font-family: "Inter", sans-serif;
}

img {
    max-width: 100%;
    display: block;
}

a {
    color: inherit;
    text-decoration: none;
}

h1, h2, h3, h4, h5 {
    font-family: "Cormorant Garamond", serif;
    margin: 0 0 12px;
    line-height: 1.05;
}

p {
    color: var(--muted);
    line-height: 1.75;
}

.container {
    width: min(1180px, calc(100% - 32px));
    margin: 0 auto;
}

.topbar {
    background: rgba(255, 255, 255, 0.9);
    border-bottom: 1px solid var(--border);
    position: sticky;
    top: 0;
    z-index: 50;
    backdrop-filter: blur(10px);
}

.nav-wrap {
    display: flex;
    align-items: center;
    justify-content: space-between;
    padding: 18px 0;
    gap: 24px;
}

.brand {
    font-size: 2rem;
    font-weight: 700;
    letter-spacing: 0.08em;
    text-transform: uppercase;
    color: var(--text);
}

.main-nav {
    display: flex;
    gap: 22px;
    color: var(--muted);
    font-size: 0.95rem;
}

.nav-actions {
    display: flex;
    align-items: center;
    gap: 12px;
}

.btn {
    display: inline-flex;
    align-items: center;
    justify-content: center;
    border-radius: 999px;
    padding: 0.9rem 1.5rem;
    cursor: pointer;
    border: 1px solid transparent;
    transition: 0.2s ease;
    font-weight: 600;
}

.btn-dark {
    background: var(--text);
    color: #fff;
}

.btn-outline {
    border-color: var(--text);
    color: var(--text);
    background: transparent;
}

.btn-outline-light {
    border-color: rgba(255, 255, 255, 0.5);
    color: white;
    background: transparent;
}

.btn:hover {
    transform: translateY(-1px);
}

.hero {
    background: linear-gradient(135deg, #251d1a 0%, #463a34 100%);
    color: white;
    padding: 72px 0 36px;
}

.hero-grid {
    display: grid;
    grid-template-columns: 1.15fr 1fr;
    align-items: center;
    gap: 32px;
}

.eyebrow {
    display: inline-block;
    letter-spacing: 0.12em;
    text-transform: uppercase;
    font-size: 0.75rem;
    opacity: 0.8;
    margin-bottom: 18px;
    color: var(--accent);
}

.hero h1 {
    font-size: clamp(3.3rem, 6vw, 5rem);
    margin-bottom: 20px;
    color: white;
}

.hero-copy p {
    font-size: 1.08rem;
    width: min(540px, 100%);
    color: rgba(255, 255, 255, 0.8);
}

.cta-row {
    display: flex;
    gap: 14px;
    margin-top: 28px;
    margin-bottom: 26px;
    flex-wrap: wrap;
}

.stats-row {
    display: flex;
    gap: 28px;
    flex-wrap: wrap;
}

.stats-row strong {
    display: block;
    font-size: 1.8rem;
    color: white;
}

.stats-row span {
    color: rgba(255, 255, 255, 0.75);
    font-size: 0.8rem;
}

.hero-card {
    border-radius: 24px;
    overflow: hidden;
    box-shadow: var(--shadow);
}

.section {
    padding: 90px 0;
}

.warm-bg {
    background: #f0e6db;
}

.section-header {
    margin-bottom: 32px;
}

.section-header.center {
    text-align: center;
}

.section-header h2 {
    font-size: clamp(2.5rem, 4vw, 3.3rem);
    color: var(--text);
}

.card-grid {
    display: grid;
    gap: 24px;
}

.three-up {
    grid-template-columns: repeat(3, minmax(0, 1fr));
}

.four-up {
    grid-template-columns: repeat(4, minmax(0, 1fr));
}

.two-up {
    grid-template-columns: repeat(2, minmax(0, 1fr));
}

.project-card {
    background: var(--panel);
    border-radius: 24px;
    overflow: hidden;
    box-shadow: var(--shadow);
    border: 1px solid var(--border);
}

.project-card img {
    width: 100%;
    height: 280px;
    object-fit: cover;
}

.project-meta {
    padding: 22px;
}

.project-meta span {
    display: inline-block;
    background: #f4ede4;
    color: var(--accent-dark);
    padding: 0.38rem 0.7rem;
    border-radius: 999px;
    font-size: 0.75rem;
    font-weight: 600;
    margin-bottom: 12px;
}

.project-meta h3 {
    font-size: 2rem;
    margin-bottom: 6px;
}

.project-foot {
    display: flex;
    align-items: center;
    justify-content: space-between;
    margin-top: 16px;
    color: var(--text);
}

.project-foot a {
    color: var(--accent-dark);
    font-weight: 600;
}

.info-card, .testimonial-card, .blog-card, .contact-card, .form-card, .panel-box, .auth-box, .stat-box {
    background: rgba(255, 255, 255, 0.8);
    border: 1px solid var(--border);
    border-radius: 24px;
    box-shadow: var(--shadow);
}

.info-card {
    padding: 24px;
}

.icon-wrap {
    width: 54px;
    height: 54px;
    border-radius: 16px;
    display: grid;
    place-items: center;
    background: rgba(168, 109, 72, 0.12);
    margin-bottom: 18px;
    color: var(--accent-dark);
    font-size: 1.2rem;
}

.testimonial-card {
    padding: 28px;
}

.stars {
    color: #d4a042;
    letter-spacing: 0.2em;
    margin-bottom: 16px;
}

.blog-card {
    overflow: hidden;
}

.blog-card img {
    height: 220px;
    width: 100%;
    object-fit: cover;
}

.blog-card-body {
    padding: 22px;
}

.page-banner {
    padding: 74px 0 36px;
    background: linear-gradient(135deg, #f7f1ec 0%, #efe2d5 100%);
}

.page-banner h1 {
    font-size: clamp(2.7rem, 4vw, 4rem);
    color: var(--text);
}

.split-layout, .contact-grid, .project-hero {
    display: grid;
    grid-template-columns: repeat(2, minmax(0, 1fr));
    gap: 30px;
    align-items: center;
}

.page-image {
    border-radius: 24px;
    box-shadow: var(--shadow);
}

.feature-list, .quiet-list {
    padding-left: 18px;
    color: var(--muted);
    line-height: 2;
}

.contact-card, .form-card {
    padding: 28px;
}

.field-row {
    display: flex;
    flex-direction: column;
    gap: 8px;
    margin-bottom: 16px;
}

input, select, textarea {
    width: 100%;
    border: 1px solid rgba(30, 27, 26, 0.12);
    background: #fff;
    border-radius: 14px;
    padding: 0.9rem 1rem;
    color: var(--text);
    font: inherit;
}

textarea {
    resize: vertical;
}

label {
    font-weight: 600;
    color: var(--text);
}

.full-width {
    width: 100%;
}

.checkbox-row {
    display: flex;
    flex-direction: row;
    align-items: center;
    gap: 10px;
}

.auth-section {
    padding: 72px 0;
}

.auth-box {
    width: min(460px, calc(100% - 24px));
    margin: 0 auto;
    padding: 30px;
}

.auth-box h2 {
    font-size: 2.5rem;
    margin-bottom: 18px;
}

.auth-link {
    margin-top: 16px;
    text-align: center;
}

.text-danger {
    color: #b63c3c;
    font-size: 0.9rem;
    margin-bottom: 10px;
}

.success-box {
    background: rgba(48, 130, 76, 0.08);
    color: #1c5b39;
    border: 1px solid rgba(48, 130, 76, 0.15);
    border-radius: 12px;
    padding: 12px 14px;
    margin-bottom: 16px;
}

.admin-panel {
    padding-top: 56px;
}

.top-actions {
    display: flex;
    justify-content: space-between;
    align-items: center;
    margin-bottom: 24px;
}

.stats-grid {
    display: grid;
    grid-template-columns: repeat(3, minmax(0, 1fr));
    gap: 20px;
    margin-bottom: 30px;
}

.stat-box {
    padding: 28px 22px;
}

.stat-box span {
    color: var(--muted);
    display: block;
    margin-bottom: 12px;
}

.stat-box strong {
    font-size: 2.2rem;
    font-family: "Cormorant Garamond", serif;
}

.data-table {
    width: 100%;
    border-collapse: collapse;
}

.data-table th, .data-table td {
    text-align: left;
    padding: 14px 12px;
    border-bottom: 1px solid var(--border);
}

.inline-form {
    display: inline;
}

.link-button {
    background: transparent;
    border: none;
    color: #b63c3c;
    padding: 0;
    cursor: pointer;
    font: inherit;
}

.single-project {
    padding-top: 60px;
}

.project-hero img {
    border-radius: 26px;
    max-height: 620px;
    object-fit: cover;
    box-shadow: var(--shadow);
}

.project-summary {
    background: rgba(255, 255, 255, 0.7);
    border: 1px solid var(--border);
    border-radius: 24px;
    padding: 24px;
    box-shadow: var(--shadow);
}

.summary-grid {
    display: grid;
    grid-template-columns: repeat(2, minmax(0, 1fr));
    gap: 18px;
    margin: 22px 0;
}

.summary-grid span, .summary-grid strong {
    display: block;
}

.footer-grid {
    display: grid;
    grid-template-columns: 1.5fr 1fr 1fr;
    gap: 24px;
    padding: 52px 0;
}

.site-footer {
    background: #221d1b;
    color: rgba(255, 255, 255, 0.8);
    border-top: 1px solid rgba(255, 255, 255, 0.08);
}

.site-footer h4, .site-footer h5 {
    color: white;
}

.site-footer ul {
    list-style: none;
    padding: 0;
    margin: 0;
    display: grid;
    gap: 8px;
}

@media (max-width: 980px) {
    .hero-grid,
    .split-layout,
    .contact-grid,
    .project-hero,
    .three-up,
    .four-up,
    .two-up,
    .footer-grid,
    .stats-grid {
        grid-template-columns: 1fr;
    }

    .main-nav {
        display: none;
    }

    .nav-wrap {
        flex-wrap: wrap;
    }
}
