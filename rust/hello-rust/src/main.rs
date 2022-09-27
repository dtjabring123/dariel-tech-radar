use ferris_says::say;
use std::io::{stdout, BufWriter};

fn main() {
    // println!("Hello, world!");

    let stdout = stdout();
    let out = b"Hello there";
    let width = 24;

    let mut w = BufWriter::new(stdout.lock());

    say(out, width, &mut w).unwrap();
}
