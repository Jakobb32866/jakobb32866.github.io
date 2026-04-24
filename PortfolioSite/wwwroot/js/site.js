export function applyTheme(theme) {
    document.documentElement.setAttribute('data-theme', theme);
}

let _rafId = null;

export function startRadar(canvasEl, skills) {
    if (_rafId) cancelAnimationFrame(_rafId);
    const DPR = window.devicePixelRatio || 1;
    const W = 460, H = 400;
    canvasEl.width = W * DPR; canvasEl.height = H * DPR;
    canvasEl.style.width = W + 'px'; canvasEl.style.height = H + 'px';
    const ctx = canvasEl.getContext('2d');
    ctx.scale(DPR, DPR);
    const cx = W / 2, cy = H / 2, R = 168;

    const blips = skills.map(label => ({
        a: Math.random() * Math.PI * 2,
        r: 0.35 + Math.random() * 0.55,
        label
    }));

    let start = null;
    function draw(ts) {
        if (!start) start = ts;
        const el = ts - start;
        ctx.clearRect(0, 0, W, H);

        const dk = document.documentElement.getAttribute('data-theme') !== 'light';
        const accent = dk ? '#f5a623' : '#b8720a';
        const fg = dk ? '#e8e4da' : '#18180e';
        const sweep = (el * 0.0005) % (Math.PI * 2);

        // rings
        [0.33, 0.66, 1].forEach(f => {
            ctx.beginPath(); ctx.arc(cx, cy, R * f, 0, Math.PI * 2);
            ctx.strokeStyle = `rgba(245,166,35,${dk ? 0.11 : 0.14})`;
            ctx.lineWidth = 1; ctx.stroke();
        });

        // crosshairs
        ctx.strokeStyle = `rgba(245,166,35,${dk ? 0.07 : 0.09})`; ctx.lineWidth = 1;
        [[cx-R,cy,cx+R,cy],[cx,cy-R,cx,cy+R]].forEach(([x1,y1,x2,y2]) => {
            ctx.beginPath(); ctx.moveTo(x1,y1); ctx.lineTo(x2,y2); ctx.stroke();
        });

        // sweep trail
        for (let a = 0; a < Math.PI * 2; a += 0.012) {
            const age = ((sweep - a) + Math.PI * 2) % (Math.PI * 2);
            if (age > 1.6) continue;
            const alpha = Math.max(0, (1.6 - age) / 1.6) * 0.32;
            ctx.beginPath(); ctx.moveTo(cx, cy);
            ctx.arc(cx, cy, R, a, a + 0.015); ctx.closePath();
            ctx.fillStyle = `rgba(245,166,35,${alpha})`; ctx.fill();
        }

        // sweep line
        ctx.beginPath(); ctx.moveTo(cx, cy);
        ctx.lineTo(cx + Math.cos(sweep) * R, cy + Math.sin(sweep) * R);
        ctx.strokeStyle = `rgba(245,166,35,0.88)`; ctx.lineWidth = 1.5; ctx.stroke();

        // blips
        blips.forEach(b => {
            const bx = cx + Math.cos(b.a) * R * b.r;
            const by = cy + Math.sin(b.a) * R * b.r;
            const age = ((sweep - b.a) + Math.PI * 2) % (Math.PI * 2);
            const alpha = age < 0.25 ? 1 : Math.max(0, (1.9 - age) / 1.9);
            if (alpha < 0.04) return;
            ctx.beginPath(); ctx.arc(bx, by, 3, 0, Math.PI * 2);
            ctx.fillStyle = `rgba(245,166,35,${alpha})`; ctx.fill();
            ctx.font = '700 9.5px "JetBrains Mono",monospace';
            ctx.fillStyle = `rgba(245,166,35,${alpha * 0.85})`;
            ctx.textAlign = bx < cx ? 'right' : 'left';
            ctx.textBaseline = 'middle';
            ctx.fillText(b.label, bx + (bx < cx ? -6 : 6), by);
        });

        // center
        ctx.beginPath(); ctx.arc(cx, cy, 4, 0, Math.PI * 2);
        ctx.fillStyle = accent; ctx.fill();

        // name
        ctx.textAlign = 'center'; ctx.textBaseline = 'middle';
        ctx.font = '800 32px "JetBrains Mono",monospace'; ctx.fillStyle = fg;
        ctx.fillText('jaszoch', cx, cy - 5);
        ctx.font = '400 11px "JetBrains Mono",monospace'; ctx.fillStyle = accent;
        const blink = Math.floor(el / 560) % 2 === 0;
        ctx.fillText('.dev' + (blink ? '█' : ' '), cx, cy + 19);

        _rafId = requestAnimationFrame(draw);
    }
    _rafId = requestAnimationFrame(draw);
}

export function stopRadar() {
    if (_rafId) { cancelAnimationFrame(_rafId); _rafId = null; }
}

export function storageGet(key) {
    return localStorage.getItem(key);
}

export function storageSet(key, value) {
    localStorage.setItem(key, value);
}